using System.Drawing;

namespace m4TR1x.Core.Models.WeatherReaderService
{
    public class DailyWeatherInfoResultModel
    {
        public string Info { get; set; }

        public string IconUrl { get; set; }
        public int Tempature { get; set; }

        public Image IconImage { get; set; }
        public Image FullImage { get; set; }
    }
}
