using m4TR1x.Business.Interfaces;
using m4TR1x.Business.Winforms.Interfaces;
using m4TR1x.Core.Winforms.Interfaces;
using System.Windows.Forms;
using static m4TR1x.Business.Interfaces.IWeatherApiReaderService;

namespace m4TR1x.UI.Winforms
{
    public partial class MainForm : Form, IApplicationForm
    {
        private readonly IFormFactoryService _formFactoryService;

        public MainForm(IFormFactoryService formFactoryService, IDailyMessageService dailyMessageService, IWeatherApiReaderService weatherApiReaderService)
        {
            _formFactoryService = formFactoryService;

            InitializeComponent();
        }

        private void btnDailyMessageForm_Click(object sender, System.EventArgs e)
        {
            var form = _formFactoryService.GetOrCreateForm<DailyMessageForm>();

            if (!form.Visible)
            {
                form.Show();
            }
            else
            {
                form.Focus();
            }
        }

        private void btnWeatherForm_Click(object sender, System.EventArgs e)
        {
            var form = _formFactoryService.GetOrCreateForm<WeatherForm>();

            if (!form.Visible)
            {
                form.Show();
            }
            else
            {
                form.Focus();
            }
        }
    }
}
