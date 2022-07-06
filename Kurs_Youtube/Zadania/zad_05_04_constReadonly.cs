using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs_Youtube.Zadania
{
    internal class zad_05_04_constReadonly
    {
        public static void Program()
        {

        }

    }
    class ApiClient
    {
        private readonly string baseUrl = "https://out-api-dev-com";
        private const string getUsersEndPoint = "/api/users";
        private readonly HttpClient httpClient = new HttpClient();
        private int defaultPort = 80;

        public void GetUsers()
        {
            var getUsersUri = $"{baseUrl}{getUsersEndPoint}";

            httpClient.GetAsync(getUsersUri);
        }
        public void PostUser()
        {

        }
        public void GetResources()
        {

        }
    }
}
