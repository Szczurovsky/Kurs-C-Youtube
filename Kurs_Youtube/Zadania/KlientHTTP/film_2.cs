using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Flurl.Http;


namespace Kurs_Youtube.Zadania.KlientHTTP
{
    internal class film_2
    {
        public static async Task Program()
        {
            var posts = await "https://jsonplaceholder.typicode.com/posts"
                .GetAsync()
                .ReceiveJson<List<Post>>();
            var selectedPost = posts.First(p => p.Id == 30);
            Console.WriteLine(selectedPost.Title);
            Console.WriteLine(selectedPost.Body);

            var postResult = await "https://jsonplaceholder.typicode.com/posts"
                .WithHeaders(new
                {
                    header = "value",
                    some_header = "va"
                }, true)
                .SetQueryParams(new
                {
                    postId = 2,
                    someVal = "val"
                })
                .PostJsonAsync(selectedPost);
            Console.WriteLine(postResult.StatusCode);


        }
    }
}
