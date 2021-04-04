using static m4TR1x.API.Business.Models.WeatherApiService.WeatherJsonModel;
using m4TR1x.API.Business.Models.WeatherApiService;
using m4TR1x.Core.Models.WeatherApiService;
using m4TR1x.API.Business.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using m4TR1x.Core.Extensions;
using System.Globalization;
using m4TR1x.Core.Services;
using m4TR1x.Core.Helpers;
using Newtonsoft.Json;
using System.Drawing;
using System.IO;
using System;

namespace m4TR1x.API.Business.Services
{
    public class WeatherApiService : BaseService, IWeatherApiService
    {
        private WeatherModel model;

        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ILogger<WeatherApiService> _logger;

        public WeatherApiService(IHostingEnvironment hostingEnvironment, ILogger<WeatherApiService> logger)
        {
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
        }

        public WeatherModel GetWeatherInfo()
        {
            if (model == null || !model.IsCorrect || (DateTime.Now - model.LastUpdateDate).Minutes > 5)
            {
                updateWeatherInfo();
            }

            return model;
        }
        public WeatherModel GetWeatherWebInfo()
        {
            var refModel = GetWeatherInfo();

            var model = new WeatherModel()
            {
                IsCorrect = refModel.IsCorrect,
                LastUpdateDate = refModel.LastUpdateDate,
                Daily = new List<DailyWeatherInfoModel>()
            };

            if (model.IsCorrect)
            {
                foreach (var day in refModel.Daily)
                {
                    var dayRow = new DailyWeatherInfoModel();

                    dayRow.Tempature = day.Tempature;
                    dayRow.FullImage = null;
                    dayRow.IconImage = null;
                    dayRow.IconUrl = day.IconUrl;
                    dayRow.Info = day.Info;

                    model.Daily.Add(dayRow);
                }
            }

            return model;
        }

        void updateWeatherInfo()
        {
            try
            {
                model = new WeatherModel();

                var jsonResult = ApiHelper.GetJsonFromApi(
                    @"http://api.openweathermap.org/data/2.5/onecall?" +
                        "lat=41.02110645976381&" +
                        "lon=29.00410819977675&" +
                        "lang=tr&" +
                        "exclude=minutely,hourly,alerts&" +
                        "units=metric&" +
                        "appid=c59b6d48f895841fa2a3508c6c3e0431"); //use your own appid

                if (jsonResult != null)
                {
                    var jsonSettings = new JsonSerializerSettings()
                    {
                        Culture = new CultureInfo("en-US")
                    };

                    var jsonModel = JsonConvert.DeserializeObject<WeatherJsonModel>(jsonResult, jsonSettings);

                    model.Daily = new List<DailyWeatherInfoModel>();
                    model.Daily.Add(CreateDailyWeatherInfoFromJsonResult(jsonModel.current));

                    foreach (var day in jsonModel.daily)
                    {
                        model.Daily.Add(CreateDailyWeatherInfoFromJsonResult(day));
                    }

                    model.IsCorrect = true;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            model = model ??= new WeatherModel();
            model.LastUpdateDate = DateTime.Now;
        }

        private DailyWeatherInfoModel CreateDailyWeatherInfoFromJsonResult(CurrentJsonModel current)
        {
            var filepath = current.weather[0].icon
                        .Replace("03d", "03dn").Replace("03n", "03dn")
                        .Replace("04d", "04dn").Replace("04n", "04dn")
                        .Replace("09d", "09dn").Replace("09n", "09dn")
                        .Replace("13d", "13dn").Replace("13n", "13dn");

            var webFilepath = $"/Content/assets/images/weather/{filepath}.png";

            filepath = ($"{_hostingEnvironment.WebRootPath}/Content/assets/images/weather/{filepath}.png").Replace("/", "\\");

            var image = Image.FromFile(filepath);
            var iconImage = (Image)image.Resize(22, 22);

            byte[] imageBytes;
            byte[] iconImageBytes;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                imageBytes = ms.ToArray();
            }

            using (var ms = new MemoryStream())
            {
                iconImage.Save(ms, image.RawFormat);
                iconImageBytes = ms.ToArray();
            }

            var model = new DailyWeatherInfoModel()
            {
                FullImage = imageBytes,
                IconImage = iconImageBytes,
                IconUrl = webFilepath,
                Info = current.weather[0].description.ToTitleCase(),
                Tempature = (int)current.temp
            };

            return model;
        }

        private DailyWeatherInfoModel CreateDailyWeatherInfoFromJsonResult(DailyJsonModel daily)
        {
            var filepath = daily.weather[0].icon
                        .Replace("03d", "03dn").Replace("03n", "03dn")
                        .Replace("04d", "04dn").Replace("04n", "04dn")
                        .Replace("09d", "09dn").Replace("09n", "09dn")
                        .Replace("13d", "13dn").Replace("13n", "13dn");

            var webFilepath = $"/Content/assets/images/weather/{filepath}.png";

            filepath = ($"{_hostingEnvironment.WebRootPath}/Content/assets/images/weather/{filepath}.png").Replace("/", "\\");

            var image = Image.FromFile(filepath);
            var iconImage = (Image)image.Resize(22, 22);

            byte[] imageBytes;
            byte[] iconImageBytes;

            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                imageBytes = ms.ToArray();
            }

            using (var ms = new MemoryStream())
            {
                iconImage.Save(ms, image.RawFormat);
                iconImageBytes = ms.ToArray();
            }

            var model = new DailyWeatherInfoModel()
            {
                FullImage = imageBytes,
                IconImage = iconImageBytes,
                IconUrl = webFilepath,
                Info = daily.weather[0].description.ToTitleCase(),
                Tempature = (int)Math.Round((daily.temp.min + daily.temp.max) / 2, 0)
            };

            return model;
        }

        public override void Dispose(bool disposing)
        {
            if (disposing)
            {
                model = null;
            }
        }
    }
}
