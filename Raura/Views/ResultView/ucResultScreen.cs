using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raura.Views.ResultView
{
    public partial class ucResultScreen : UserControl, MnIResultView
    {
        public ucResultScreen()
        {
            InitializeComponent();
            InitializeLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeLabel()
        {
            teamBlueLabels = new[]
            {
                BteamLabel_1,
                BteamLabel_2,
                BteamLabel_3,
                BteamLabel_4,
                BteamLabel_5,
            };

            teamRedLabels = new[]
            {
                RteamLabel_1,
                RteamLabel_2,
                RteamLabel_3,
                RteamLabel_4,
                RteamLabel_5,
            };
        }

        private Label[] teamBlueLabels;
        private Label[] teamRedLabels;
    }
}
