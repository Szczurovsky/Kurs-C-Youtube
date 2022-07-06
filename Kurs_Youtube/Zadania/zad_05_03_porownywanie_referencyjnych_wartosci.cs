using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_05_03_porownywanie_referencyjnych_wartosci
    {
        public static void Program()
        {
            int horsePower1 = 350;
            int horsePower2 = 350;

            bool valueTypeEquality = horsePower1 == horsePower2;
            Car car1 = new Car(horsePower1);
            Car car2 = new Car(horsePower2);

            //bool referenceTypeEquality = car1.Equals(car2);
            bool referenceTypeEquality = car1 == car2;
            bool checkSys = 1 == 1;
            Console.WriteLine("Sprawdzenie rownosci " + checkSys);
            Console.WriteLine($"valueTypeEquality: {valueTypeEquality}");
            Console.WriteLine($"referenceTypeEquality: {referenceTypeEquality}");
        }

    }
    class Car
    {
        public static bool operator ==(Car left,Car right)
        {
            return Equals(left, right);
        }
        public static bool operator !=(Car left, Car right)
        {
            return !Equals(left, right);
        }
        public override bool Equals(object? obj)
        {
           if (obj == null)
            {
                return false;
            }
            if (this.GetType() != obj.GetType())
                return false;

            Car car = (Car)obj;
            return this.HorsePower == car.HorsePower;
        }
        public Car(int horsePower)
        {
            HorsePower = horsePower;
        }
        public int HorsePower { get; set; }
    }
}
