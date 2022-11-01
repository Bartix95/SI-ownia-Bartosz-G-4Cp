using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilowniaBartek
{

    public class data
    {
        public List<Uzytkownicy> Uzytkownicy { get; set; }
    }
    public class Uzytkownicy
    {
        public string nazwaUzytkownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public string Haslo { get; set; }
        public int MinutyNaKarnecie { get; set; }
    }
}
