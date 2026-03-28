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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                IsCheck = true;
            else
                IsCheck = false;
        }

        public event EventHandler? MainRequested;
        public string InputPlayer => richTextBox1.Text;
        public bool IsCheck
        {
            get => checkBox1.Checked;
            set => checkBox1.Checked = value;
        }
    }
}
