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
        private object testObject;

        public class TestObject
        {
            public static string Teststring = "Teststring";
        }

        public object Testtask()
        {
            return testObject;
        }

        //public void SetTestObject(object value)
        //{
        //    testObject = value;
        //}

        //public Object testtask()
        //{

        //    TestObject obj = new TestObject();

            //Console.WriteLine(TestObject.Teststring);

        //    return obj;
        //}

        //public string testtask()
        //{
        //    string teststring = "teststring";
        //    return teststring;
        //}

    }

}
