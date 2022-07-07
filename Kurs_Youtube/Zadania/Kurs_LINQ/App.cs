using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace Kurs_Youtube.Zadania.Kurs_LINQ
{
    internal class App
    {
        public static void Program()
        {
            string csvPath = @"C:\Users\dawid.szczurkowski\source\repos\Zad_1\Kurs_Youtube\Zadania\Kurs_LINQ\googleplaystore1.csv";
            var googleApps = LoadGoogleAps(csvPath);

            //Display(googleApps);
            DataSetOperation(googleApps);

        }
        static void DataVerification(IEnumerable<GoogleApp> googleApps)
        {
            var allOperatorResult = googleApps.Where(a => a.Category == Category.WEATHER).All(a => a.Reviews > 10);
            Console.WriteLine(allOperatorResult);
        }
        static void DataSetOperation(IEnumerable<GoogleApp> googleApps)
        {

            //union zlaczy dwa zbiory, wynik wszystkie elementy a i b, jesli sie pokrywaja nie beda powielone
            //intersect czesc wspolna z dwoch zbiorow, te elementy ktore byly w a i w b
            //except tylko czesc zbioru A ktora nie pokrywa sie ze zbiorem b
            //distinct unikalne
            var paidAppsCategories = googleApps.Where(a => a.Type == Type.Paid).Select(a => a.Category).Distinct();
            var setA = googleApps.Where(a => a.Rating > 4.7 && a.Type == Type.Paid && a.Reviews > 1000);
            var setB = googleApps.Where(a => a.Name.Contains("Pro") && a.Rating >4.6 && a.Reviews > 10000);
            //Display(setA);

            //Console.WriteLine("\n");

            //Display(setB);
            //var  appsUnion = setA.Union(setB);

        }
        static void OrderData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.4 && app.Category == Category.BEAUTY);
            var sortedHighRatedBeautyApps = highRatedBeautyApps.OrderBy(app => app.Rating)
                .ThenBy(app=>app.Name);

            Display(sortedHighRatedBeautyApps);

        }
        static void DivideData(IEnumerable<GoogleApp> googleApps)
        {
            var highRatedBeautyApps = googleApps.Where(app => app.Rating > 4.4 && app.Category == Category.BEAUTY);
            var first5HighRatedBeautyApps = highRatedBeautyApps.Take(5);

            Display(first5HighRatedBeautyApps);
        }
        static void ProjectData(IEnumerable<GoogleApp> googleApps)
        {
            //select wybiera na podstawie predykatu
            //selectMany pomaga np, kiedy mamy kolekcje kolekcji w odczycie tejze kolekcji
            //zwraca kolekcje typu anonimowy(typ dla ktorego nie ma okreslonej klasy)
            var highRatedBeautyApps = googleApps.Where((GoogleApp app) => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            var highRatedBeautyAppsNames = highRatedBeautyApps.Select(app => app.Name);
            var dtos = highRatedBeautyApps.Select(app => new GoogleAppDto()
            {
                Reviews = app.Reviews,
                Name = app.Name,
            });
            var anonymousDtos = highRatedBeautyApps.Select(app => new
            {
                Reviews = app.Reviews,
                Name = app.Name,
                Category = app.Category
            });
            foreach (var dto in anonymousDtos)
            {
                Console.WriteLine(dto.Name + "=" + dto.Reviews ,dto.Category);
            }
            // foreach(var dto in dtos)
            // {
            //     Console.WriteLine(dto.Name,dto.Reviews);
            // }
            //var genres = highRatedBeautyApps.SelectMany(app => app.Genres);
            // Console.WriteLine("\n");
            // Console.WriteLine(String.Join("\n", genres));
            //Display(highRatedBeautyApps);
        }
        static void GetData(IEnumerable<GoogleApp> googleApps)
        {
            //first bierze pierwszy element spelniajacy dany predykat w ()
            //single sprawdza czy jest jeden element, jesli jest wiecej to wyrzuca wyjatek
            //...orDefault broni programiste przed wyjatkiem, kiedy nie ma zadnego elementu spelniajacego, zwraca wtedy null
            //last zwraca ostatni element, no kto by sie spodziewal :D
            //
            var highRate = googleApps.Where((GoogleApp app) => app.Rating > 4.6);
            var highRatedBeautyApps = highRate.Where((GoogleApp app) => app.Rating > 4.6 && app.Category == Category.BEAUTY);
            Display(highRatedBeautyApps);

            var firstHighRatedBeautyApp = highRatedBeautyApps.FirstOrDefault((GoogleApp app) => app.Reviews < 50);
            Console.WriteLine("firstHighRatedBeautyApp");
            Display(firstHighRatedBeautyApp);
        }
        static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var googleApp in googleApps)
            {
                Console.WriteLine(googleApp);
            }

        }
        static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
        }

        static List<GoogleApp> LoadGoogleAps(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }

        }
    }
}
