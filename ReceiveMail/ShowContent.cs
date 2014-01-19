using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiveMail
{
    public partial class ShowContent : Form
    {
        public string html;

        public ShowContent()
        {
            InitializeComponent();
        }

        private void ShowContent_Load(object sender, EventArgs e)
        {
            this.webBrowser1.DocumentText = html;
        }

    }
}
