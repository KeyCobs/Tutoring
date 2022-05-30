using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutor_01_GET_POST.Controllers
{
    [ApiController]
    [Route("Weather")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("THIS_IS_NEW_ROUTE")]
        public IEnumerable<Books> Get(int amountOfPrints = 3)
        {
            var rng = new Random();
            ////_logger.Log(LogLevel.Information, "HTTP GET");
            //Books books = new Books();
            //books.Author = "Dungeons and Dragons";
            //books.Title = "Ghost of Saltmarsh";
            //books.Description = "swamps and stuff";
            //books.Rating = rng.Next(0, 5);


            return Enumerable.Range(1, amountOfPrints).Select(index => new Books
            {
                Author = "Dungeons and Dragons",
                Title = "Ghost of Saltmarsh",
                Description = "swamps and stuff",
                Rating = rng.Next(0, 5)
        }).ToArray();
        }
    }
}
