using m4TR1x.Business.Interfaces;
using m4TR1x.Business.Winforms.Interfaces;
using m4TR1x.Core.Winforms.Interfaces;
using System.Linq;
using System.Text;
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

        private void btnNewTestForm_Click(object sender, System.EventArgs e)
        {
            var form = _formFactoryService.CreateForm<TestForm>();
            form.Show();
        }

        private void btnDisplayAllForms_Click(object sender, System.EventArgs e)
        {
            var forms = _formFactoryService.Forms;

            if (forms.Count == 0)
            {
                MessageBox.Show("No forms to display");
                return;
            }

            var sb = new StringBuilder();

            forms.ForEach(f =>
            {
                sb.Append($"=> {f.Name}:{f.Text}\n");
            });

            MessageBox.Show(sb.ToString(), "Forms");
        }

        private void btnCloseAllForms_Click(object sender, System.EventArgs e)
        {
            var form = _formFactoryService.Forms.FirstOrDefault();
            if (form == null)
            {
                return;
            }

            do
            {
                form.Close();
                form = _formFactoryService.Forms.FirstOrDefault();
            }
            while (form != null);
        }
    }
}
