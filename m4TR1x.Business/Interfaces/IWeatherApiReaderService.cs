using m4TR1x.Core.Models.WeatherReaderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Business.Interfaces
{
    public interface IWeatherApiReaderService
    {
        public WeatherResultModel CurrentWeather { get; }

        public delegate void WeatherUpdatedDelegate();

        public event WeatherUpdatedDelegate WeatherUpdated;
    }
}
