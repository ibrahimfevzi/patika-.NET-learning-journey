using Microsoft.AspNetCore.Mvc;

namespace HelloWebapi.Controllers;

[ApiController]
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

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    [HttpGet]
    //api/WeatherForecast?id=1
    public WeatherForecast GetById([FromQuery] int id)
    {
         var weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();

    if (id >= 1 && id <= weatherForecasts.Length)
    {
        return weatherForecasts[id - 1];
    }

    // İlgili kimlik numarasına sahip hava durumu tahmini bulunamadıysa null dönebilirsiniz veya özel bir durum döndürebilirsiniz.
    return null;
}

[HttpGet("{id}")]
// /api/WeatherForecast/1
public WeatherForecast GetForecast([FromRoute] int id)
{
    var weatherForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
    {
        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    })
    .ToArray();

    if (id >= 1 && id <= weatherForecasts.Length)
    {
        return weatherForecasts[id - 1];
    }

    // İlgili kimlik numarasına sahip hava durumu tahmini bulunamadıysa null dönebilirsiniz veya özel bir durum döndürebilirsiniz.
    return null;
}


}


