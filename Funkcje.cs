using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SilowniaBartek
{
    public static class Funkcje
    {

        public static List<Uzytkownicy> FetchUsers()
        {
            var JSON = "";

            var path = $@"{Environment.CurrentDirectory}\Dane.json";
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

        /// <param name="UserToSave"></param>
        public static void SaveUsers(Uzytkownicy UserToSave)
        {
            var ExistingUsers = FetchUsers();
            if (ExistingUsers.Any(x => x.nazwaUzytkownika == UserToSave.nazwaUzytkownika) == false)
            {
                ExistingUsers.Add(UserToSave);
            }
            else
            {
                ExistingUsers.Remove(ExistingUsers.First(x => x.nazwaUzytkownika == UserToSave.nazwaUzytkownika));
                ExistingUsers.Add(UserToSave);
            }
            var toSerialize = new data();
            toSerialize.Uzytkownicy = ExistingUsers;
            var path = $@"{Environment.CurrentDirectory}\Dane.json";
            var Serialized = JsonConvert.SerializeObject(toSerialize);
            var File = new FileStream(path, FileMode.Open, FileAccess.Write);
            File.SetLength(0);
            File.Close();
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(Serialized);
            }


        }


        /// <param name="UsersToSave"></param>
        public static void SaveUsers(List<Uzytkownicy> UsersToSave)
        {
            var path = $@"{Environment.CurrentDirectory}\Dane.json";
            var toSerialize = new data();
            toSerialize.Uzytkownicy = UsersToSave;
            var Serialized = JsonConvert.SerializeObject(toSerialize);
            var File = new FileStream(path, FileMode.Append, FileAccess.ReadWrite);
            File.SetLength(0);
            File.Close();
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(Serialized);
            }
        }

        /// <param name="Czas"></param>
        public static string KonwertujCzas(int Czas)
        {
            string ReturnString = "";
            var Godziny = Math.Floor((decimal)Czas / 60);
            var Minuty = Math.Floor((decimal)Czas % 60);
            ReturnString = $"{Godziny}:{Minuty}";
            return ReturnString;

        }
    }
}
