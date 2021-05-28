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
        public async Task<Models.Root> Testtask(string SearchOption)
        {
                //Models.Root DrinksModel = new();

                string teststring = "teststring";

                Console.WriteLine("start of task: " + teststring);

                using var client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=" + SearchOption);

                response.EnsureSuccessStatusCode();

                string Body = await response.Content.ReadAsStringAsync();

                object BodyJSONobj = JsonConvert.DeserializeObject(Body);

                Models.Root BodyJSONmdl = JsonConvert.DeserializeObject<Models.Root>(Body);

            //JsonConvert.PopulateObject(Body, DrinksModel);

            if (BodyJSONmdl.drinks == null)
                    {
                        Console.WriteLine("body is null");
                        
                    }

                    else
                    {
                        Console.WriteLine("body is not null");
                        //Console.WriteLine("Body: " + BodyJSONmdl.drinks[0].strDrink);
                        //Console.WriteLine("Body Object: " + BodyJSONobj);
                        Console.WriteLine("Res: " + response.StatusCode);
            }

            Console.WriteLine("end of task: " + teststring);

            return BodyJSONmdl;

            }


    }

}
