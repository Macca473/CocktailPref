using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorWasm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    

    public class DrinksAPIController : ControllerBase
    {
        public async Task<object> Testtask()
        {
                Models.IEnumerable<Root> DrinksModel = new();
                string teststring = "teststring";

                Console.WriteLine("start of task: " + teststring);

                using var client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=vodka");

                response.EnsureSuccessStatusCode();

                string Body = await response.Content.ReadAsStringAsync();

                object BodyJSON = JsonConvert.DeserializeObject<object>(Body);

                

                   if (Body == null)
                    {
                        Console.WriteLine("body is null");
                    }

                    else
                    {
                        Console.WriteLine("body is not null");
                        Console.WriteLine("Body: " + BodyJSON);
                        Console.WriteLine("Res: " + response.StatusCode);

                //object FullDrinksQurery = DrinksModel.Append(body);
            }

            Console.WriteLine("end of task: " + teststring);

            return DrinksModel;

            }


    }

}
