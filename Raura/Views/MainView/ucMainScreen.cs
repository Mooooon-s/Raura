using Raura.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raura.Views.MainView
{
    public partial class ucMainScreen : UserControl, MnIMainView
    {
        public ucMainScreen()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MainRequested?.Invoke(this, e);
        }

        public event EventHandler? MainRequested;
        public string InputPlayer => richTextBox1.Text;
    }
}
