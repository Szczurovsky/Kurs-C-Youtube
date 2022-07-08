using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania.WebScrapping
{
    internal class countryDetails
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public List<cityModel> Cities { get; set; }
    }
}
