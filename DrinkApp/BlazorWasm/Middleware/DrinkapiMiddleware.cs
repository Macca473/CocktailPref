using System;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Http;

namespace BlazorWasm.Middleware
{
    public class DrinkapiMiddleware
    {

        public class testobject
        {
            string Teststring = "Teststring";
        }

        public testobject testtask()
        {

            testobject obj = new testobject();

            return obj;
        }

        //public string testtask()
        //{
        //    string teststring = "teststring";
        //    return teststring;
        //}

    }

}
