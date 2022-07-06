using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Kurs_Youtube.Zadania
{
    internal class zad_06_02_serializacja
    {
        public static void Program()
        {
            //Player player = new Player()
            //{
            //    Name = "Mario",
            //    Level = 1,
            //    HealthPoints = 100,
            //    Statistics = new List<Statistic>()
            //    {
            //        new Statistic()
            //        {
            //            Name = "Strength",
            //            Points = 10
            //        },
            //        new Statistic()
            //        {
            //            Name = "Intelligence",
            //            Points = 10
            //        }
            //    }
            //};
            //player.Level++;

            //string playerSerialized = JsonConvert.SerializeObject(player);

            //File.WriteAllText(@"C:/PlikiTekstowe/Json/playerSerialized.json", playerSerialized);
            string playerSerialized = File.ReadAllText("C:/PlikiTekstowe/Json/playerSerialized.json");
            Player player = JsonConvert.DeserializeObject<Player>(playerSerialized);
            Console.WriteLine(player.Name);
        }
    }
    class Player
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HealthPoints { get; set; }
        public List<Statistic> Statistics { get; set; }
    }
    public class Statistic
    {
        public string Name { get; set; }    
        public int Points { get; set; }  
    }
}
