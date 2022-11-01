using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace SilowniaBartek
{
    public partial class Logowanie : Form
    {

      
        public Logowanie()
        {
            InitializeComponent();
        }

        private void ZalogujBtn_Click(object sender, EventArgs e)
        {


            string NazwaUzytkownika = this.nUzTxtBox.Text;
            string Haslo = this.HasloTxtBox.Text;
            var UzytkownicyL = Funkcje.FetchUsers();
            bool CzyDobreDane = SprawdzDaneLogowania(NazwaUzytkownika, Haslo);
            if (CzyDobreDane)
            {
                MessageBox.Show("Valid user");
                var Uzytkownik = UzytkownicyL.First(x => x.nazwaUzytkownika == NazwaUzytkownika);
                var Glowne = new StronaGlowna(Uzytkownik);
                Glowne.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid user");
            }
        }

        bool SprawdzDaneLogowania(string Nazwa, string Haslo)
        {
            List<Uzytkownicy> ZarejestrowaniUzytkownicy = Funkcje.FetchUsers();

            foreach (Uzytkownicy Uzytkownik in ZarejestrowaniUzytkownicy)
            {
                if (Uzytkownik.Haslo == Haslo && Uzytkownik.nazwaUzytkownika == Nazwa)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
