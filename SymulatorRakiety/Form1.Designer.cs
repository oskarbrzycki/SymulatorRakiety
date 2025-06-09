namespace SymulatorRakiety
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtMasa = new System.Windows.Forms.TextBox();
            this.txtSila = new System.Windows.Forms.TextBox();
            this.txtCzas = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timerLot = new System.Windows.Forms.Timer(this.components);
            this.lblTytul = new System.Windows.Forms.Label();
            this.lblMasa = new System.Windows.Forms.Label();
            this.lblSila = new System.Windows.Forms.Label();
            this.lblCzas = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblSymulacja = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMasa
            // 
            this.txtMasa.Location = new System.Drawing.Point(138, 68);
            this.txtMasa.Name = "txtMasa";
            this.txtMasa.Size = new System.Drawing.Size(100, 20);
            this.txtMasa.TabIndex = 0;
            // 
            // txtSila
            // 
            this.txtSila.Location = new System.Drawing.Point(138, 107);
            this.txtSila.Name = "txtSila";
            this.txtSila.Size = new System.Drawing.Size(100, 20);
            this.txtSila.TabIndex = 1;
            // 
            // txtCzas
            // 
            this.txtCzas.Location = new System.Drawing.Point(138, 145);
            this.txtCzas.Name = "txtCzas";
            this.txtCzas.Size = new System.Drawing.Size(100, 20);
            this.txtCzas.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(25, 181);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(213, 32);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timerLot
            // 
            this.timerLot.Interval = 1000;
            this.timerLot.Tick += new System.EventHandler(this.timerLot_Tick_1);
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTytul.ForeColor = System.Drawing.Color.White;
            this.lblTytul.Location = new System.Drawing.Point(19, 9);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(316, 36);
            this.lblTytul.TabIndex = 7;
            this.lblTytul.Text = "SYMULATOR RAKIETY";
            this.lblTytul.Click += new System.EventHandler(this.lblTytul_Click);
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMasa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMasa.Location = new System.Drawing.Point(3, 68);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(129, 19);
            this.lblMasa.TabIndex = 8;
            this.lblMasa.Text = "Masa rakiety (kg):";
            // 
            // lblSila
            // 
            this.lblSila.AutoSize = true;
            this.lblSila.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSila.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSila.Location = new System.Drawing.Point(12, 107);
            this.lblSila.Name = "lblSila";
            this.lblSila.Size = new System.Drawing.Size(102, 19);
            this.lblSila.TabIndex = 9;
            this.lblSila.Text = "Siła ciągu (N):";
            // 
            // lblCzas
            // 
            this.lblCzas.AutoSize = true;
            this.lblCzas.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCzas.Location = new System.Drawing.Point(21, 144);
            this.lblCzas.Name = "lblCzas";
            this.lblCzas.Size = new System.Drawing.Size(93, 19);
            this.lblCzas.TabIndex = 10;
            this.lblCzas.Text = "Czas lotu (s):";
            this.lblCzas.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(32, 229);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(206, 199);
            this.txtLog.TabIndex = 11;
            // 
            // lblSymulacja
            // 
            this.lblSymulacja.AutoSize = true;
            this.lblSymulacja.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSymulacja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSymulacja.Location = new System.Drawing.Point(29, 433);
            this.lblSymulacja.Name = "lblSymulacja";
            this.lblSymulacja.Size = new System.Drawing.Size(209, 19);
            this.lblSymulacja.TabIndex = 5;
            this.lblSymulacja.Text = "Sekunda: 0, Wysokość: 0,00 m";
            this.lblSymulacja.Click += new System.EventHandler(this.lblSymulacja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(765, 469);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblCzas);
            this.Controls.Add(this.lblSila);
            this.Controls.Add(this.lblMasa);
            this.Controls.Add(this.lblTytul);
            this.Controls.Add(this.lblSymulacja);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.txtSila);
            this.Controls.Add(this.txtMasa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SymulatorRakiety";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMasa;
        private System.Windows.Forms.TextBox txtSila;
        private System.Windows.Forms.TextBox txtCzas;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timerLot;
        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.Label lblSila;
        private System.Windows.Forms.Label lblCzas;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblSymulacja;
    }
}

