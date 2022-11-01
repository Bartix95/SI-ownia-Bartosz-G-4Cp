using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilowniaBartek
{
    public partial class DodajUzytkownika : Form
    {
        public DodajUzytkownika()
        {
            InitializeComponent();
        }

        private void DodajUzytkownikaBtn_Click(object sender, EventArgs e)
        {
            var Haslo = HasloTxtBox.Text;
            var NazwaUzytkownika = NazwaUzytkownikaTxtBox.Text;
            var Wiek = WiekTxtBox.Text;
            var Imie = ImieTxtBox.Text;
            var Nazwisko = NazwiskoTxtBox.Text;
            var CzasNaKarnecie = GodzinyNaKarnet.Value;
            var NowyUzytkownik = new Uzytkownicy();
            NowyUzytkownik.Haslo = Haslo;
            NowyUzytkownik.nazwaUzytkownika = NazwaUzytkownika;
            NowyUzytkownik.Wiek = Int32.Parse(Wiek);
            NowyUzytkownik.Imie = Imie;
            NowyUzytkownik.Nazwisko = Nazwisko;
            NowyUzytkownik.MinutyNaKarnecie = CzasNaKarnecie * 60;
            Funkcje.SaveUsers(NowyUzytkownik);
            var PanelGlownyForm = new StronaGlowna(NowyUzytkownik);
            PanelGlownyForm.Show();
            this.Hide();
        }

        private void WrocDoPaneluBtn_Click(object sender, EventArgs e)
        {
            var PanelGlownyForm = new StronaGlowna();
            PanelGlownyForm.Show();
            this.Hide();
        }

        private void GodzinyNaKarnet_Scroll(object sender, EventArgs e)
        {
            CzasKarnetLbl.Text = $"Czas na karnecie: {GodzinyNaKarnet.Value}";
        }
    }
}
