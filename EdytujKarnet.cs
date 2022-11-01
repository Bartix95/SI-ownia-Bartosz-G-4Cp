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
    public partial class EdytujKarnet : Form
    {


        private int DodatkowyCzas;
        private Uzytkownicy Uzytkownik;
        public EdytujKarnet(Uzytkownicy uz)
        {
            InitializeComponent();
            Uzytkownik = uz;
            ObecnyCzasLbl.Text = Funkcje.KonwertujCzas(uz.MinutyNaKarnecie);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            DodatkowyCzas = trackBar1.Value;
            var nowyCzas = Funkcje.KonwertujCzas(Uzytkownik.MinutyNaKarnecie + (DodatkowyCzas * 60));
            NowyCzasLbl.Text = nowyCzas;
        }

        private void ZatwierdzBtn_Click(object sender, EventArgs e)
        {
            DodatkowyCzas = trackBar1.Value;
            var nowyCzas = Funkcje.KonwertujCzas(Uzytkownik.MinutyNaKarnecie + (DodatkowyCzas * 60));
            ObecnyCzasLbl.Text = nowyCzas;
            Uzytkownik.MinutyNaKarnecie += (DodatkowyCzas * 60);
            Funkcje.SaveUsers(Uzytkownik);
            trackBar1.Value = 0;
        }

        private void WrocBtn_Click(object sender, EventArgs e)
        {
            var PanelGlowny = new StronaGlowna(Uzytkownik);
            PanelGlowny.Show();
            this.Hide();
        }


    }
}
