using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

            //var path = Path.Combine(Directory.GetCurrentDirectory(), "\\fileName.txt");

            //string LocPath = Directory.GetCurrentDirectory();

            var myTask = Task.Run(() => System.IO.File.ReadAllText(path: @"D:\dotNetStuff\CocktailPrefRepo\CocktailPref\DrinkApp\BlazorWasm\Controllers\TestTxt.txt"));

            string Getstringtest = await myTask;

            Console.WriteLine("Local Path: ", myTask);

            LocalVarTestModel.Teststr = Getstringtest;

            return LocalVarTestModel;
        }
    }


}
