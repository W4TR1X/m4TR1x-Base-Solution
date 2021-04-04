using m4TR1x.Business.Interfaces;
using m4TR1x.Business.Winforms.Interfaces;
using System.Windows.Forms;

namespace m4TR1x.Ui.Winforms
{
    public partial class MainForm : Form
    {
        private readonly IFormFactoryService _formFactoryService;
        private readonly IDailyMessageService _dailyMessageService;

        public MainForm(IFormFactoryService formFactoryService, IDailyMessageService dailyMessageService)
        {
            _formFactoryService = formFactoryService;
            _dailyMessageService = dailyMessageService;

            InitializeComponent();
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
