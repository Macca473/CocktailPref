﻿using System;
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
        public async Task<object> Testtask()
        {
            Models.TestModel LocalVarTestModel = new();

            async Task<string> GetSearch(string drink) 
            {
                string drinksapi = "test";

                var client = new HttpClient();
                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://www.thecocktaildb.com/api/json/v1/1/search.php?s=vodka")
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    if (body == null)
                    {
                        Console.WriteLine("body is null");
                    }

                    else
                    {
                        Console.WriteLine("body is not null");
                        Console.WriteLine("Body: ", body);
                    }
                    
                }

                return drinksapi;
            };



            var myTask = Task.Run(() => (GetSearch("drink")));



            string Getstringtest = await myTask;

            Console.WriteLine("Local Path: ", myTask);

            LocalVarTestModel.Teststr = Getstringtest;

            return LocalVarTestModel;
        }
    }

}
