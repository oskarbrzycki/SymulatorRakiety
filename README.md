# 🚀 Symulator Rakiety

## 📌 Opis projektu

**Symulator Rakiety** to aplikacja typu **Windows Forms**, która pozwala na wizualną symulację startu rakiety w oparciu o podstawowe dane fizyczne:

- ✅ Wprowadzenie parametrów (masa, siła ciągu, opór powietrza)
- ✅ Animacja lotu rakiety (ruch w górę)
- ✅ Zatrzymanie rakiety przy braku odpowiedniej siły ciągu

Projekt został stworzony w języku **C# (.NET Framework)** z wykorzystaniem biblioteki **Windows Forms** do obsługi graficznego interfejsu użytkownika.

---

## 🛠️ Funkcje

- **Wprowadzanie danych** – użytkownik podaje masę rakiety, siłę ciągu oraz opór
- **Warunek fizyczny** – jeśli siła ciągu nie przewyższa sił oporu i grawitacji, rakieta nie startuje
- **Animacja** – rakieta płynnie unosi się w górę na ekranie, z aktualizacją wysokości i czasu
- **Symulacja w czasie rzeczywistym** – oparta na timerze, z możliwością stopniowej wizualizacji
- **Zapisywanie wyników w pliku tekstowym** 

---

## 🧪 Instrukcje dla użytkowania

### ✅ Format wprowadzania danych

Użytkownik wpisuje dane do odpowiednich pól tekstowych:

| Pole            | Opis                        |
|-----------------|-----------------------------|
| `Masa (kg)`     | Masa rakiety w kilogramach  |
| `Siła ciągu (N)`| Całkowita siła silnika      |
| `Opór (N)`      | Siła oporu atmosfery        |

Przycisk **Start** uruchamia symulację.

---

## 📁 Struktura plików
├── bin/Debug/ # Folder z plikiem wykonywalnym (.exe)
├── Form1.cs # Główna logika aplikacji
├── Form1.Designer.cs # Definicja UI (Windows Forms)
├── Rakieta.cs # Klasa pomocnicza do przechowywania danych
├── README.md # Dokumentacja projektu
