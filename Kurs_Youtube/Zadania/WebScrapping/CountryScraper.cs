using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Kurs_Youtube.Zadania.WebScrapping
{
    internal class CountryScraper
    {
        private const string baseUrl = "https://unece.org/trade/cefact/unlocode-code-list-country-and-territory";

        public IEnumerable<countryModel> GetCountries()
        {
            var web = new HtmlWeb();
            var document = web.Load(baseUrl);

            var tableRows = document.QuerySelectorAll("table tr").Skip(1);
            foreach (var item in tableRows)
            {
                var tds = item.QuerySelectorAll("td");

                var code = tds[0].InnerText;
                var name = tds[1].InnerText;
                var href = tds[1].QuerySelector("a").Attributes["href"].Value;
                

                yield return new countryModel(code, name,href);
            }
        }
    }
}
