using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BlazorWasm.Controllers
{
    public class GETDrinksController : ControllerBase
    {
        public async Task<Models.Root> GETDrinks(int searchType, string searchOption)
        {
            string[] searchTypeList = {"search.php?s=","filter.php?i="};

            using var client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync("https://www.thecocktaildb.com/api/json/v1/1/" + searchTypeList[searchType] + searchOption);

            response.EnsureSuccessStatusCode();

            string Body = await response.Content.ReadAsStringAsync();

            object BodyJSONobj = JsonConvert.DeserializeObject(Body);

            Models.Root BodyJSONmdl = JsonConvert.DeserializeObject<Models.Root>(Body);

            Console.WriteLine("Res: " + response.StatusCode);

            Console.WriteLine("GETDrinksBody: " + BodyJSONmdl);

            return BodyJSONmdl;
        }
    }

}
