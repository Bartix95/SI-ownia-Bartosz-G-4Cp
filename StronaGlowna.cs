using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace SilowniaBartek
{
    public partial class StronaGlowna : Form
    {
        Uzytkownicy ZalogowanyUzytkownik;
        List<Uzytkownicy> FetchUsers()
        {
            var JSON = "";
            var path = @"D:\BartekTechniczne\SI£OWNIA_BARTOSZ_GROCKI_$CP\SI£OWNIA\SI³owniaBartek\Dane.json";
            using (StreamReader sr = new StreamReader(path))
            {
                JSON = sr.ReadToEnd();
            }
            var Deserialized = JsonConvert.DeserializeObject<data>(JSON);
            List<Uzytkownicy> UzytkownicyL = Deserialized.Uzytkownicy.Select(x => new Uzytkownicy()
            {
                nazwaUzytkownika = x.nazwaUzytkownika,
                Haslo = x.Haslo,
                MinutyNaKarnecie = x.MinutyNaKarnecie,
                Imie = x.Imie,
                Nazwisko = x.Nazwisko,
                Wiek = x.Wiek
            }).ToList();

            return UzytkownicyL;
        }


        void DisplayUserInfo()
        {
            this.ImieLbl.Text = ZalogowanyUzytkownik.Imie;
            this.WiekLbl.Text = ZalogowanyUzytkownik.Wiek.ToString();
            this.NazwaLbl.Text = ZalogowanyUzytkownik.nazwaUzytkownika;
            this.NazwiskoLbl.Text = ZalogowanyUzytkownik.Nazwisko;
            this.CzasPozostalyLbl.Text = Funkcje.KonwertujCzas(ZalogowanyUzytkownik.MinutyNaKarnecie);

        }

        public StronaGlowna(Uzytkownicy uz)
        {
            InitializeComponent();
            var Uzytkownicy = FetchUsers();
            ZalogowanyUzytkownik = uz;
            DisplayUserInfo();
            FillInComboList();
        }
        public StronaGlowna()
        {
            InitializeComponent();
            FillInComboList();
        }

        private void FillInComboList()
        {
            List<Uzytkownicy> Users = FetchUsers();
            foreach (Uzytkownicy uzytkownik in Users)
            {
                this.UzytkownicyCombo.Items.Add(uzytkownik.nazwaUzytkownika);
            }

        }
        private void EdytujKarnetBtn_Click(object sender, EventArgs e)
        {
            var EdytujKarnetForm = new EdytujKarnet(ZalogowanyUzytkownik);
            EdytujKarnetForm.Show();
            this.Hide();
        }

        private void DodajUzytkownikaBtn_Click(object sender, EventArgs e)
        {
            var DodajUzytkownikaForm = new DodajUzytkownika();
            DodajUzytkownikaForm.Show();
            this.Hide();
        }
        private void EdytujCzasNaSilowniBtn_Click(object sender, EventArgs e)
        {
            var EdytujCzasNaSilowniForm = new EdytujCzasNaSilowni(ZalogowanyUzytkownik);
            EdytujCzasNaSilowniForm.Show();
            this.Hide();
        }


        private void WybierzU¿ytkownikaBtn_Click(object sender, EventArgs e)
        {
            var Uzytkownicy = Funkcje.FetchUsers();
            ZalogowanyUzytkownik = Uzytkownicy.FirstOrDefault(x => x.nazwaUzytkownika == UzytkownicyCombo.SelectedItem.ToString());
            DisplayUserInfo();
        }
    }
}
