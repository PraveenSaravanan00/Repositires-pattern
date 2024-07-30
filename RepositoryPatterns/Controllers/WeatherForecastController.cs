using Microsoft.AspNetCore.Mvc;
using RepositoryPatterns.service.WeatherService;

namespace RepositoryPatterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly WeathserServiceInterface _WeathserServiceInterfaceRef;
        
       public WeatherForecastController(ILogger<WeatherForecastController> logger,WeathserServiceInterface weathserServiceInterfaceRef)
        {
            _logger = logger;
            _WeathserServiceInterfaceRef= weathserServiceInterfaceRef;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _WeathserServiceInterfaceRef.Get();
        }
    }
}
