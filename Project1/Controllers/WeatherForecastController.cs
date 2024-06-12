using MassTransit;
using MassTransit.Testing;
using Microsoft.AspNetCore.Mvc;
using Project1.Models;
using Project1.RabitMQ.Consumer;
using Project1.RabitMQ.Sender;

namespace Project1.Controllers
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

        private readonly IEventBus _bus;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IEventBus bus)
        {
            _logger = logger;
            _bus = bus;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<dynamic> Get(CancellationToken cancellationToken)
        {
            var s = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            await _bus.PublicAsync(new UpdateCustomerAddress
            {
                CommandId = 1,
                Name = "This "
            });

            return s;
        }
    }
}
