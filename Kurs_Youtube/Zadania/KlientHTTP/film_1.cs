using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

namespace Kurs_Youtube.Zadania.KlientHTTP
{
    internal class film_1
    {
        public static async Task Program()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");
                var json = await result.Content.ReadAsStringAsync();
                var posts = JsonConvert.DeserializeObject<List<Post>>(json);
                var selectedPost = posts.First(p => p.Id == 30);
                Console.WriteLine(selectedPost.Title);
                Console.WriteLine(selectedPost.Body);

                var postJsonContent = new StringContent(JsonConvert.SerializeObject(selectedPost));

                var postResult = await httpClient
                    .PostAsync("https://jsonplaceholder.typicode.com/posts", postJsonContent);

                using (var postRequestMessage =
                    new HttpRequestMessage(HttpMethod.Post, "https://jsonplaceholder.typicode.com/posts"))
                {
                    postRequestMessage.Headers.Add("content-type", "application/json");
                    postRequestMessage.Content = postJsonContent;

                    var post2Result = await httpClient.SendAsync(postRequestMessage);
                }

                var queryParams = HttpUtility.ParseQueryString(string.Empty);
                queryParams["postId"] = "1";
                queryParams["postParam"] = "someVal";

                var formattedParams = queryParams.ToString();
            }

        }
    }
}
