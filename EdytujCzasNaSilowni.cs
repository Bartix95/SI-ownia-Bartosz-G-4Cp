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
    public partial class EdytujCzasNaSilowni : Form
    {
        private int DodatkowyCzas;
        private Uzytkownicy ZalogowanyUzytkownik;
        public EdytujCzasNaSilowni(Uzytkownicy uz)
        {
            InitializeComponent();
            ZalogowanyUzytkownik = uz;
            ObecnyCzasLbl.Text = Funkcje.KonwertujCzas(ZalogowanyUzytkownik.MinutyNaKarnecie);
        }

        private void ZatwierdzBtn_Click(object sender, EventArgs e)
        {
            DodatkowyCzas = trackBar1.Value;
            var nowyCzas = Funkcje.KonwertujCzas(ZalogowanyUzytkownik.MinutyNaKarnecie - (DodatkowyCzas * 60));
            ObecnyCzasLbl.Text = nowyCzas;
            ZalogowanyUzytkownik.MinutyNaKarnecie -= (DodatkowyCzas * 60);
            Funkcje.SaveUsers(ZalogowanyUzytkownik);
            trackBar1.Value = 0;

        }

        private void WrocBtn_Click(object sender, EventArgs e)
        {
            var PanelGlowny = new StronaGlowna(ZalogowanyUzytkownik);
            PanelGlowny.Show();
            this.Hide();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DodatkowyCzas = trackBar1.Value;
            var nowyCzas = Funkcje.KonwertujCzas(ZalogowanyUzytkownik.MinutyNaKarnecie - (DodatkowyCzas * 60));
            NowyCzasLbl.Text = nowyCzas;
        }
    }
}
