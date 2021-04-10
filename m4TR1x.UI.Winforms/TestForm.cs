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
    public partial class TestForm : Form, IApplicationForm
    {
        public TestForm()
        {
            InitializeComponent();

            label1.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            this.Text = label1.Text;
        }
    }
}
