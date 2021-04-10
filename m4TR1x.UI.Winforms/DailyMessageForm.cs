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

namespace m4TR1x.UI.Winforms
{
    public partial class DailyMessageForm : Form, IApplicationForm
    {

        private readonly IDailyMessageService _dailyMessageService;
        public DailyMessageForm(IDailyMessageService dailyMessageService)
        {
            _dailyMessageService = dailyMessageService;

            InitializeComponent();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            getDailyMessage();
        }

        private void DailyMessageForm_Load(object sender, EventArgs e)
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
