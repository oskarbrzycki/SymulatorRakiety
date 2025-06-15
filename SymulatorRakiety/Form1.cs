using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SymulatorRakiety
{
    public partial class Form1 : Form
    {
        private PictureBox rocket;
        private Timer timer;
        private float totalTime = 5f;    // Rakieta leci przez X sekund
        private float elapsedTime = 0f;
        private float deltaT = 0.05f;    // 50 ms = 0.05 sekundy
        private int speed = 5;           // Ilość pikseli, o które rakieta przesuwa się w górę co jeden tick

        struct Rakieta
        {
            public double Masa;
            public double SilaCiągu;
            public double CzasLotu;
            public double Opór;
        }
        
        
        List<double> wysokosci = new List<double>();
        int indeksSekundy = 0;
        int startY;

     

        public Form1()
        {
            InitializeComponent();
            this.Width = 800;
            this.Height = 500;

            InitRocket();
            InitTimer();
            timerLot = new Timer();
            timerLot.Interval = 1000; // 1 sekunda
            timerLot.Tick += timerLot_Tick;
        }
       
           





        //ANIMAAAAAAACJA
        private void InitRocket()
        {
            rocket = new PictureBox();
            rocket.Image = Image.FromFile("rocket.gif"); // Rakieta (czubek do góry)
            rocket.BackColor = Color.Transparent;
            rocket.SizeMode = PictureBoxSizeMode.AutoSize;
            rocket.Location = new Point(300, 300); // Początkowa pozycja
            rocket.Visible = false; // Rakieta niewidoczna na start
            this.Controls.Add(rocket);
        }
        private void InitTimer()
        {
            timer = new Timer();
            timer.Interval = (int)(deltaT * 1000); // 50 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsedTime += deltaT;

            // Przesuń rakietę w górę
            rocket.Top -= speed;

            // Zatrzymaj animację po X sekundach
            if (elapsedTime >= totalTime || rocket.Top <= 0)
            {
                timer.Stop();
            }
        }
        //PROGRAM/INTERFEJS

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Reset
            indeksSekundy = 0;
            wysokosci.Clear();
            txtLog.Clear();
            

            // Pobierz dane od użytkownika
            Rakieta rakieta;
            rakieta.Masa = double.Parse(txtMasa.Text);
            rakieta.SilaCiągu = double.Parse(txtSila.Text);
            rakieta.CzasLotu = double.Parse(txtCzas.Text);
            rakieta.Opór = 100; // Stała wartość oporu
            

            List<string> raport = new List<string>();
            Symuluj(rakieta, 1, raport);

            //Zapisywanie wyników do logu
            txtLog.Lines = raport.ToArray();
            System.IO.File.WriteAllLines("raport_symulacji.txt", raport.ToArray());
            string sciezka = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\raport_symulacji.txt";
            System.IO.File.WriteAllLines(sciezka, raport.ToArray());


            // Start animacji
            timerLot.Start();
            elapsedTime = 0f;
            rocket.Location = new Point(300, 300); // reset pozycji
            rocket.Visible = true;
            timer.Start();
        }
        //Rekurencja
        void Symuluj(Rakieta rakieta, int sekunda, List<string> raport)
        {
            if (sekunda > rakieta.CzasLotu)
                return;

            double g = 9.81;
            double przyspieszenie = (rakieta.SilaCiągu - rakieta.Opór - rakieta.Masa * g) / rakieta.Masa;
            double wysokosc = 0.5 * przyspieszenie * sekunda * sekunda;
            double predkosc = przyspieszenie * sekunda;

            wysokosci.Add(wysokosc);
            raport.Add($"Sekunda: {sekunda}, Wysokość: {wysokosc:F2} m, Prędkość: {predkosc:F2} m/s");
            if (rakieta.SilaCiągu <= rakieta.Masa * 9.81 + rakieta.Opór)
            {
                MessageBox.Show("Siła ciągu jest zbyt mała, rakieta nie wystartuje!", "Błąd");
                return;
            }

            Symuluj(rakieta, sekunda + 1, raport);
        }

        private void timerLot_Tick(object sender, EventArgs e)
        {
            if (indeksSekundy >= wysokosci.Count)
            {
                timerLot.Stop();
                return;
            }

            double maxWys = wysokosci.Max();
            double aktualna = wysokosci[indeksSekundy];
            int przesuniecie = (int)((aktualna / maxWys) * 200);

            lblSymulacja.Text = $"Sekunda: {indeksSekundy + 1}, Wysokość: {aktualna:F2} m";

            indeksSekundy++;
        }


        void lblSymulacja_Click(object sender, EventArgs e)
        {
            if (indeksSekundy > 0 && indeksSekundy <= wysokosci.Count)
            {
                double aktualna = wysokosci[indeksSekundy - 1];
                lblSymulacja.Text = $"Sekunda: {indeksSekundy}, Wysokość: {aktualna:F2} m";
            }
        }
            
            private void lblTytul_Click(object sender, EventArgs e)
        {

        }

        private void timerLot_Tick_1(object sender, EventArgs e)
        {

        }




    }
    }
        
       