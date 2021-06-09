using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWasm.Controllers
{
    public class catchMessageController : ControllerBase
    {

        public string catchMessage { get; set; }

        public string GETcatchMessage()
        {
            Console.WriteLine("Getting catchMessage " + catchMessage);

            return catchMessage;
        }

        public void PostcatchMessage(string PCM)
        {
            catchMessage = PCM;

            Console.WriteLine("Posting catchMessage " + catchMessage + " | " + PCM);
        }
    }
}
