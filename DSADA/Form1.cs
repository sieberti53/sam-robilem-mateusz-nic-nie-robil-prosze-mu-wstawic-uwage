using System;
using System.Text;
using System.Windows.Forms;

namespace INF._04_01_23._01_SG
{
    public partial class Form1 : Form
    {
        // Zmienna do przechowywania wygenerowanego hasła
        private string wygenerowaneHaslo = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /**********************************************
         nazwa funkcji: generuj_Click
         opis funkcji: Generuje hasło o podanej długości, zawierające określone typy znaków.
         parametry: sender – obiekt wywołujący zdarzenie
                    e – argumenty zdarzenia
         zwracany typ i opis: void – funkcja wyświetla hasło w oknie komunikatu.
         autor: EE-Informatyk.pl
        ***********************************************/
        private void generuj_Click(object sender, EventArgs e)
        {
            try
            {
                int liczbaZnakow = int.Parse(znaki.Text);
                if (liczbaZnakow <= 0)
                {
                    MessageBox.Show("Liczba znaków musi być większa od zera!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string dozwoloneZnaki = "";
                if (litery.Checked) dozwoloneZnaki += "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                if (cyfry.Checked) dozwoloneZnaki += "0123456789";
                if (specjalne.Checked) dozwoloneZnaki += "!@#$%^&*()-_=+<>?";

                if (string.IsNullOrEmpty(dozwoloneZnaki))
                {
                    MessageBox.Show("Wybierz przynajmniej jedną opcję znaków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                StringBuilder haslo = new StringBuilder();
                Random rand = new Random();

                for (int i = 0; i < liczbaZnakow; i++)
                {
                    int index = rand.Next(dozwoloneZnaki.Length);
                    haslo.Append(dozwoloneZnaki[index]);
                }

                // Zapisz hasło do zmiennej globalnej
                wygenerowaneHaslo = haslo.ToString();

                MessageBox.Show($"Wygenerowane hasło: {wygenerowaneHaslo}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj poprawną liczbę znaków!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**********************************************
         nazwa funkcji: zatwierdz_Click
         opis funkcji: Zatwierdza dane pracownika i wyświetla je wraz z wygenerowanym hasłem.
         parametry: sender – obiekt wywołujący zdarzenie
                    e – argumenty zdarzenia
         zwracany typ i opis: void – funkcja wyświetla dane pracownika w oknie komunikatu.
         autor: EE-Informatyk.pl
        ***********************************************/
        private void zatwierdz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(imie.Text) || string.IsNullOrWhiteSpace(nazwisko.Text) || stanowisko.SelectedIndex == -1)
            {
                MessageBox.Show("Wypełnij wszystkie dane pracownika!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tworzenie danych pracownika, w tym hasła
            string danePracownika =
                $"Imię: {imie.Text}\n" +
                $"Nazwisko: {nazwisko.Text}\n" +
                $"Stanowisko: {stanowisko.SelectedItem}\n" +
                $"Hasło: {wygenerowaneHaslo}";

            MessageBox.Show($"Dodano pracownika:\n\n{danePracownika}", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Puste metody obsługi zdarzeń
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
