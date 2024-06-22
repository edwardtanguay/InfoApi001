using InfoApi001.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace InfoApi001.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowSpecificOrigins")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Swelteri" +
            "" +
            "ng", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            // InfoManager infoManager = new InfoManager();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            // return Enumerable.Range(1, 7).Select(index => infoManager.GetInfo()).ToArray();
        }

        [HttpGet("learnItems", Name = "GetLearnItems")]
        public IEnumerable<string> GetLearnItems()
        {
            return new string[]
            {
            "Learn ASP.NET Core",
            "Learn Entity Framework",
            "Learn Docker",
            "Learn Kubernetes",
            "nnn"
            };
        }
    }
}
