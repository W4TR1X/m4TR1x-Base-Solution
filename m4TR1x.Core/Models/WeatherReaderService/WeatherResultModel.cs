using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Models.WeatherReaderService
{
    public class WeatherResultModel
    {
        public List<DailyWeatherInfoResultModel> Daily { get; set; }

        public DateTime LastUpdateDate { get; set; }

        public bool IsCorrect { get; set; }
    }
}
