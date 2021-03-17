﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DrinkAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DrinkAPIController : ControllerBase
    {

        private readonly ILogger<DrinkAPIController> _logger;

        public DrinkAPIController(ILogger<DrinkAPIController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<DrinkSearch> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
             //{
             //   Date = 10


             //})
            .ToArray();
        }
    }
}
