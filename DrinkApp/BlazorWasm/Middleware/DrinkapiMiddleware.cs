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
        //public object testObject;

        public partial class TestObject
        {
            public string Testarg { get; set; }
        }

        public object Testtask()
        {
            TestObject obj = new();

            obj.Testarg = "teststring";

            return obj;
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
