using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raura.Views.StartView
{
    public partial class ucStartScreen : UserControl , MnIStartView
    {
        public ucStartScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartRequested?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler? StartRequested;
    }
}
