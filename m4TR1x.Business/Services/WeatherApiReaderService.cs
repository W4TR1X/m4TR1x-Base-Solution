using m4TR1x.Business.Interfaces;
using m4TR1x.Core.Extensions;
using m4TR1x.Core.Helpers;
using m4TR1x.Core.Models.WeatherApiService;
using m4TR1x.Core.Models.WeatherReaderService;
using m4TR1x.Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace m4TR1x.Business.Services
{
    public class WeatherApiReaderService : BaseService, IWeatherApiReaderService
    {
        public WeatherResultModel CurrentWeather => getWeather();

        WeatherResultModel _currentWeather;

        public event IWeatherApiReaderService.WeatherUpdatedDelegate WeatherUpdated;

        public WeatherApiReaderService()
        {
            Task.Run(() =>
            {
                while (WeatherUpdated == null)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(3));
                }

                while (!Disposed)
                {
                    getWeather();

                    if (_currentWeather != null && _currentWeather.IsCorrect)
                    {
                        //Fire event
                        if (WeatherUpdated != null) WeatherUpdated.DynamicInvoke();

                        Thread.Sleep(TimeSpan.FromMinutes(5));
                    }
                    else
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(30));
                    }
                };
            });

        }
        WeatherResultModel getWeather()
        {
            if (_currentWeather == null || (DateTime.Now - _currentWeather.LastUpdateDate).Minutes > 5)
            {
                loadWeather();
            }

            return _currentWeather;
        }

        WeatherResultModel loadWeather()
        {
            try
            {
                var jsonResult = ApiHelper.GetJsonFromApi(PathHelper.HTTP_SERVER_PATH + @"/api/weatherapi/getcurrentweatherinfo");

                if (jsonResult != null)
                {
                    var weatherResult = JsonConvert.DeserializeObject<WeatherModel>(jsonResult);

                    _currentWeather = new WeatherResultModel()
                    {
                        Daily = new List<DailyWeatherInfoResultModel>(),
                        IsCorrect = weatherResult.IsCorrect,
                        LastUpdateDate = weatherResult.LastUpdateDate
                    };

                    foreach (var day in weatherResult.Daily)
                    {
                        _currentWeather.Daily.Add(new DailyWeatherInfoResultModel()
                        {
                            FullImage = day.FullImage.AsImage(),
                            IconImage = day.IconImage.AsImage(),
                            IconUrl = day.IconUrl,
                            Info = day.Info,
                            Tempature = day.Tempature
                        });
                    }
                }
            }
            catch (Exception)
            { 
            
            }

            return _currentWeather;
        }

        public override void Dispose(bool disposing)
        {
            _currentWeather = null;
        }
    }
}
