using m4TR1x.Core.Models.WeatherApiService;

namespace m4TR1x.API.Business.Interfaces
{
    public interface IWeatherApiService
    {
        WeatherModel GetWeatherInfo();
        WeatherModel GetWeatherWebInfo();
    }
}
