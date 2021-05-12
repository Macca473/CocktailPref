using System;
using System.Collections.Generic;
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

            var myTask = Task.Run(() =>

            var path = Path.Combine(Directory.GetCurrentDirectory(), "\\fileName.txt")

            System.IO.File.ReadAllText(path: @"d:\dotNetStuff\TestTxt.txt"));

            string Getstringtest = await myTask;

            LocalVarTestModel.Teststr = Getstringtest;

            return LocalVarTestModel;
        }
    }


}
