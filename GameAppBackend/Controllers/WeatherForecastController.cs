using Microsoft.AspNetCore.Mvc;

// # TODO : DELETE THIS FILE
namespace GameAppBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly Guid? _id;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _id = Guid.NewGuid();
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

        [HttpPost(Name = "PostWeatherForecast")]
        public JsonResult Post([FromBody] WeatherForecast weatherForecast)
        {
            if (ModelState.IsValid)
            {
                Dictionary<String, String?> map = new Dictionary<String, String?>();
                map.Add("weatherSummary:", weatherForecast.Summary);
                _logger.Log(LogLevel.Information, _id + " - Post to WeatherForecast Successful", map);
                return new JsonResult(map);
            }
            else
            {
                HttpResponseMessage httpResponseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
                return new JsonResult(httpResponseMessage);
            }
        }
    }
}