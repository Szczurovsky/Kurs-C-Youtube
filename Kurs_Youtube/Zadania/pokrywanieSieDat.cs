using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class pokrywanieSieDat
    {
        public static void Program()
        {
            var bookedReservations = GetBookedReservations();
            DisplayReservations(bookedReservations);

            Console.WriteLine("Wprowadz nową datę rezerwacji w formacie yyyy-MM-dd");

            string startDateString = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(startDateString, "yyyy-MM-dd", null);

            Console.WriteLine("Wprowadź nowa datę końca rezerwacji: ");
            string endDateString = Console.ReadLine();
            DateTime endDate = DateTime.ParseExact(endDateString, "yyyy-MM-dd", null);

            bool isReservationPosssible = IsNewReservationPossible(startDate, endDate, bookedReservations);

            if(isReservationPosssible)
            {
                Console.WriteLine("Rezerwacja zakonczona pomyslnie");
            }
            else
            {
                Console.WriteLine("Rezerwacja się nie udała");
            }

        }
        static bool IsNewReservationPossible(DateTime startDate, DateTime endDate, List<Reservation> bookedReservations)
        {
            foreach (var bookedReservation in bookedReservations)
            {
                if (startDate.Date >= bookedReservation.From.Date && startDate.Date <= bookedReservation.To.Date 
                    || endDate.Date >= bookedReservation.From.Date && endDate.Date <= bookedReservation.To.Date)
                {
                    return false;
                }
                if(startDate.Date <= bookedReservation.From.Date && endDate.Date >= bookedReservation.To.Date)
                {
                    return false;
                }
            }
           

            return true;
        }
        static void DisplayReservations(List<Reservation> bookedReservations)
        {
            Console.WriteLine("booked Reservations");
            foreach(var bookedReservation in bookedReservations)
            {
                Console.WriteLine($"From: {bookedReservation.From.ToString("yyyy-MM-dd")}," + 
                                  $"To : {bookedReservation.To.ToString("yyyy-MM-dd")}");
            }
            
        }
        static List<Reservation> GetBookedReservations()
        {
            var reservations = new List<Reservation>()
            {
                new Reservation(new DateTime(2021, 6, 10), new DateTime(2021,6,12)),
                new Reservation(new DateTime(2021, 6, 19), new DateTime(2021,6,20)),
                new Reservation(new DateTime(2021, 6, 24), new DateTime(2021,6,26)),
                new Reservation(new DateTime(2021, 7, 24), new DateTime(2021,7,25)),
            };
            return reservations;
        }
    }
    
    class Reservation
    {
        public Reservation(DateTime @from, DateTime to)
        {
            From = @from;
            To = to;
        }
        public DateTime From { get; set; }  
        public DateTime To { get; set; }    
    }
}
