using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodatkowe_cwiczenia.Zadania.Mini_kadry
{
    internal class Pracownik
    {
        private string _nazwisko, _imie, _miejsce_urodzenia;
        private Adres _adres;
        private double _placa_podstawowa, _premia;
        private DateTime _data_urodzenia, _data_1_zatrudnienia;
        public string Nazwisko { get { return _nazwisko; } set { _nazwisko = value; } }
        public string Imie { get { return _imie; } set { _imie = value; } }
        public string Miejsce_urodzenia { get { return _miejsce_urodzenia; } set { _miejsce_urodzenia = value; } }
        public Adres Adres { get { return _adres; } set { _adres = value; } }
        public double Placa_podstawowa { get { return _placa_podstawowa; } set { _placa_podstawowa = value; } }
        public double Premia { get { return _premia; } set { _premia = value; } }
        public DateTime Data_urodzenia { get { return _data_urodzenia; } set { _data_urodzenia = value; } }
        public DateTime Data_1_zatrudnienia { get { return _data_1_zatrudnienia;} set { _data_1_zatrudnienia = value; } }   
    }
}
