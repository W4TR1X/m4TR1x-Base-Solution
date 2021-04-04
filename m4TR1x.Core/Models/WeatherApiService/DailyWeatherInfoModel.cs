using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m4TR1x.Core.Models.WeatherApiService
{
    public class DailyWeatherInfoModel
    {
        public string Info { get; set; }

        public string IconUrl { get; set; }
        public int Tempature { get; set; }

        public byte[] IconImage { get; set; }
        public byte[] FullImage { get; set; }
    }
}
