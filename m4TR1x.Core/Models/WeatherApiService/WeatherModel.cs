using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Models.WeatherApiService
{
    public class WeatherModel
    {
        public List<DailyWeatherInfoModel> Daily { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public bool IsCorrect { get; set; }
    }
}
