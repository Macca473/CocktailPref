using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    

    public class DrinksAPIController : ControllerBase
    {

        public string teststring = "teststring";

        public async Task<object> Testtask()
        {
                Models.IEnumerable<Root> DrinksModel = new();

                Console.WriteLine("start of task: ", teststring);

                var client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=vodka");

                response.EnsureSuccessStatusCode();

                string Body = await response.Content.ReadAsStringAsync();

                

                    if (Body == null)
                    {
                        Console.WriteLine("body is null");
                    }

                    else
                    {
                        Console.WriteLine("body is not null");
                        Console.WriteLine("Body: ", teststring);

                        //object FullDrinksQurery = DrinksModel.Append(body);
                    }

            Console.WriteLine("end of task: ", teststring);

            return DrinksModel;

            }


    }

}
