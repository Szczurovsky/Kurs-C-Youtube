using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania.WebScrapping
{
    internal class countryModel
    {
        public countryModel(string code, string name, string href)
        {
            Code = code;
            Name = name;
            Href = href;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }

    }
}
