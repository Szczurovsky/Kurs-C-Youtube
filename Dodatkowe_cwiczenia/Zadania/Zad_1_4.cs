using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodatkowe_cwiczenia.Zadania
{
    internal class Zad_1_4
    {
        public static void Zad1_4()
        {
            Numbers n1 = new Numbers(2, 1);
            n1.Mnozenie();
        }
    }
    class Numbers
    {
        private double _a, _b;

        public Numbers(double a, double b)
        {
            A = a;
            B = b;
          
        }

        public double A { get { return _a; } set { _a = value; } }
        public double B { get { return _b; } set { _b = value; } }

        public void Mnozenie()
        {
            Console.WriteLine("Wartość pomnożonych liczb to " + _a*_b);
        }
    }
}
