using Microsoft.AspNetCore.Mvc;

namespace SchoolAPI.Controllers
{
    //This first tag tells .Net to treat this controller as an API controller 
    //Without it, .Net default to thinking this is a Web App controller
    [ApiController]

    //This route tag sets the base url for the whole api. All Endpoints need to have this tag in their URL 
    //If the Route has [Controller] it automatically sets the base url to match the name of our controller 
    //In this case it would be WeatherForecastController. 
    [Route("[controller]")]
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

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}