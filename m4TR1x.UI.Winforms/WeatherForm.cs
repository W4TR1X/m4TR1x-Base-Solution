using m4TR1x.Business.Interfaces;
using m4TR1x.Core.Winforms.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static m4TR1x.Business.Interfaces.IWeatherApiReaderService;

namespace m4TR1x.UI.Winforms
{
    public partial class WeatherForm : Form, IApplicationForm
    {
        private readonly IWeatherApiReaderService _weatherApiReaderService;
        private readonly IWeatherApiReaderService.WeatherUpdatedDelegate weatherUpdatedDelegate;

        public WeatherForm(IWeatherApiReaderService weatherApiReaderService)
        {
            weatherUpdatedDelegate = new WeatherUpdatedDelegate(weatherUpdated);
            _weatherApiReaderService = weatherApiReaderService;

            InitializeComponent();

            _weatherApiReaderService.WeatherUpdated += weatherUpdated;

            weatherUpdated();
        }

        private void weatherUpdated()
        {
            if (InvokeRequired)
            {
                Invoke(weatherUpdatedDelegate);
                return;
            }

            var cw = _weatherApiReaderService.CurrentWeather;

            if (cw != null && cw.IsCorrect)
            {
                lblLoading.Visible = true;

                day0LgImage.Image = cw.Daily[0].FullImage;

                day0Temp.Text = $"{cw.Daily[0].Tempature}°c";
                day0Info.Text = $"{cw.Daily[0].Info}";

                day1Image.Image = cw.Daily[2].FullImage;
                day2Image.Image = cw.Daily[3].FullImage;
                day3Image.Image = cw.Daily[4].FullImage;
                day4Image.Image = cw.Daily[5].FullImage;
                day5Image.Image = cw.Daily[6].FullImage;
                day6Image.Image = cw.Daily[7].FullImage;

                toolTip1.SetToolTip(day1Image, cw.Daily[2].Info);
                toolTip1.SetToolTip(day2Image, cw.Daily[3].Info);
                toolTip1.SetToolTip(day3Image, cw.Daily[4].Info);
                toolTip1.SetToolTip(day4Image, cw.Daily[5].Info);
                toolTip1.SetToolTip(day5Image, cw.Daily[6].Info);
                toolTip1.SetToolTip(day6Image, cw.Daily[7].Info);

                day1Temp.Text = $"{cw.Daily[2].Tempature}°c";
                day2Temp.Text = $"{cw.Daily[3].Tempature}°c";
                day3Temp.Text = $"{cw.Daily[4].Tempature}°c";
                day4Temp.Text = $"{cw.Daily[5].Tempature}°c";
                day5Temp.Text = $"{cw.Daily[6].Tempature}°c";
                day6Temp.Text = $"{cw.Daily[7].Tempature}°c";

                day1Name.Text = DateTime.Now.Date.AddDays(1).ToString("dddd");
                day2Name.Text = DateTime.Now.Date.AddDays(2).ToString("dddd");
                day3Name.Text = DateTime.Now.Date.AddDays(3).ToString("dddd");
                day4Name.Text = DateTime.Now.Date.AddDays(4).ToString("dddd");
                day5Name.Text = DateTime.Now.Date.AddDays(5).ToString("dddd");
                day6Name.Text = DateTime.Now.Date.AddDays(6).ToString("dddd");

                updateLabel.Text = "Son Güncelleme: " + cw.LastUpdateDate.ToString("dd/MM/yyyy HH:mm:ss");

                lblLoading.Visible = false;
            }
        }

        private void WeatherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _weatherApiReaderService.WeatherUpdated -= weatherUpdated;
        }
    }
}
