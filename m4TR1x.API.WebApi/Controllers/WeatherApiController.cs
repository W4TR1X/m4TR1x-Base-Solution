using m4TR1x.API.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace m4TR1x.API.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherApiController : ControllerBase
    {
        private readonly IWeatherApiService _weatherApiService;

        public WeatherApiController(IWeatherApiService weatherApiService)
        {
            _weatherApiService = weatherApiService;
        }

        [HttpGet("GetCurrentWeatherInfo")]
        public JsonResult GetCurrentWeatherInfo()
        {
            return new JsonResult(_weatherApiService.GetWeatherInfo());
        }

        [HttpGet("GetCurrentWeatherWebInfo")]
        public JsonResult GetCurrentWeatherWebInfo()
        {
            return new JsonResult(_weatherApiService.GetWeatherWebInfo());
        }
    }
}
