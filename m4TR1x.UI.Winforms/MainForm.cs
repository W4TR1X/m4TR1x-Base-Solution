using m4TR1x.Business.Interfaces;
using m4TR1x.Business.Winforms.Interfaces;
using System.Windows.Forms;
using static m4TR1x.Business.Interfaces.IWeatherApiReaderService;

namespace m4TR1x.Ui.Winforms
{
    public partial class MainForm : Form
    {
        private readonly IFormFactoryService _formFactoryService;
        private readonly IDailyMessageService _dailyMessageService;
        private readonly IWeatherApiReaderService _weatherApiReaderService;

        private readonly IWeatherApiReaderService.WeatherUpdatedDelegate weatherUpdatedDelegate; 

        public MainForm(IFormFactoryService formFactoryService, IDailyMessageService dailyMessageService, IWeatherApiReaderService weatherApiReaderService)
        {
            weatherUpdatedDelegate = new WeatherUpdatedDelegate(weatherUpdated);

            _formFactoryService = formFactoryService;
            _dailyMessageService = dailyMessageService;
            _weatherApiReaderService = weatherApiReaderService;

            InitializeComponent();

            _weatherApiReaderService.WeatherUpdated += weatherUpdated;
        }

        private void weatherUpdated()
        {
            if (InvokeRequired)
            {
                Invoke(weatherUpdatedDelegate);
                return;
            }

            var cw = _weatherApiReaderService.CurrentWeather;

            if (cw.IsCorrect)
            {
                pbWeatherImage.Image = cw.Daily[0].FullImage;
                lblWeatherText.Text = cw.Daily[0].Tempature + "°c";
                lbltemp.Text = cw.Daily[0].Info;
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            getDailyMessage();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            getDailyMessage();
        }

        void getDailyMessage()
        {
            var dailyMessage = _dailyMessageService.GetDailyMessage();

            lblMessage.Text = dailyMessage.Message;
            lblAuthor.Text = dailyMessage.Author;
        }
    }
}
