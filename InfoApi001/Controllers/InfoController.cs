using InfoApi001.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace InfoApi001.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AllowSpecificOrigins")]
    public class InfoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Swelteri" +
            "" +
            "ng", "Scorching"
        };

        private readonly ILogger<InfoController> _logger;

        public InfoController(ILogger<InfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetInfo")]
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
            "string and StringBuilder",
            "numbers: int, decimal, long, float, double",
            "dates",
            "boolean",
            "(typed) arrays, Join(), Split(), multidimensional arrays",
            "operators, including ternary and null coalescing operator",
            "if/switch",
            "foreach, for, while, do/while",
            "custom types, e.g. books, reports, employees, etc.",
            "head vs. stack, simple classes and structs",
            "extension methods",
            "consuming and creating events",
            "generic List<T>",
            "generic Stack<T>",
            "generic Queue<T>",
            "generic Dictionary<TKey,TValue>",
            "LINQ to objects",
            "LINQ to SQL",
            "object-oriented programming with classes",
            "constructors",
            "properties, methods, fields",
            "private, protected, internal, public",
            "virtual/override, abstract, static",
            "abstract classes and interfaces",
            "OOP design patterns",
            "Decorator Pattern"
            };
        }
    }
}
