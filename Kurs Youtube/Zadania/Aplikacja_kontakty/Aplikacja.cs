using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania.Aplikacja_kontakty
{
    //dodac petle i wrzucic do case
    internal class Aplikacja
    {
       
        public static void Apka()
        {
            Dictionary<string, Kontakt> Contacts = GetContacts();

            WyświetlKontakty(Contacts);
            
            Console.WriteLine("Czy chcesz dodac nowy kontakt? \nAby dodać nowego użytkownika wciśnij enter.\nAby wyjść wpisz `exit`");
            string inputUser = Console.ReadLine();
            if (inputUser == "")
            {
                Contacts = AddKontakt(Contacts);
            }
            else
            {
                Console.WriteLine("Wpisano exit");

            }
            foreach (KeyValuePair<string, Kontakt> item in Contacts)
            {
                Console.WriteLine($"Nazwa kontaktu: {item.Value.Nazwa}, Numer telefonu: {item.Value.Numer_telefonu}");
            }
            Console.WriteLine("Podaj numer użytkownika, którego chcesz znaleźć!");
            int NumberInput = int.Parse(Console.ReadLine());
            WyświetlPoNumerze(NumberInput, Contacts);
            
           
            WyświetlPoNazwa( Contacts);
            RemoveContact(Contacts); 

        }
        public static Dictionary<string, Kontakt> GetContacts()
        {
            return new Dictionary<string, Kontakt>
           {
               { "Dawid Szczurkowki", new Kontakt("Dawid Szczurkowski", 888888999)},
               { "Wika Nowak", new Kontakt("Wika nowa", 000444999) },
               { "Wika Nowaks", new Kontakt("Wika nowa", 123123123) }
           };
        }
        public static Dictionary<string, Kontakt> AddKontakt(Dictionary<string,Kontakt> Contacts)
        {
            Console.WriteLine("Proszę Wpisać Imię i Nazwisko");
            string inputName = Console.ReadLine();
            Console.WriteLine("Proszę wpisać numer telefonu");
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber.ToString().Length >= 9 && inputName.Length >= 3)
            {
                Contacts.Add(inputName, new Kontakt(inputName, inputNumber));
                return Contacts;
            }
            else
            {
                Console.WriteLine("Nie wprowadziłeś poprawnego numeru lub wprowadzona przez Ciebie nazwa jest za krótka");
                return Contacts;
            }
        }
        public static void WyświetlKontakty(Dictionary<string, Kontakt> Contacts)
        {
            foreach (KeyValuePair<string, Kontakt> item in Contacts)
            {
                Console.WriteLine($"Nazwa kontaktu: {item.Value.Nazwa}, Numer telefonu: {item.Value.Numer_telefonu}");
            }
        }
        public static void WyświetlPoNumerze(int numer,Dictionary<string, Kontakt> Contacts)
        {
            var kontakt = Contacts.SingleOrDefault(obj=>obj.Value.Numer_telefonu == numer).Value;   
            Console.WriteLine($"Nazwa kontaktu: {kontakt.Nazwa}, numer telefonu: {kontakt.Numer_telefonu}");
        }
        public static void WyświetlPoNazwa( Dictionary<string, Kontakt> Contacts)
        {
            Console.WriteLine("Podaj nazwę użytkownika, którego chcesz znaleźć!");
            string nazwa = Console.ReadLine();
            List<int> nazwaKontaktu = Contacts.Where(x=>x.Value.Nazwa == nazwa).Select(x => x.Value.Numer_telefonu).ToList();
            foreach (var item in nazwaKontaktu)
            {
                Console.WriteLine($"Nazwa kontaktu: {nazwa}, numer: {item}");
            }
        
        }
        public static Dictionary<string,Kontakt> RemoveContact(Dictionary<string, Kontakt> Contacts)
        {
            Console.WriteLine("Podaj numer kontaktu ktory chcesz usunąć");
            int numberToRemove = int.Parse(Console.ReadLine());
            var kontakt = Contacts.SingleOrDefault(obj => obj.Value.Numer_telefonu == numberToRemove);
            Contacts.Remove(kontakt.Key);
            WyświetlKontakty(Contacts);
            return Contacts;
        }
    }
}
