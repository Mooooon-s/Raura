using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            //InitializeLabel();
        }

        public ucResultScreen(List<string> list)
        {
            InitializeComponent();
            InitializeLabel(list);
            ShowLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RetryRequested?.Invoke(this, EventArgs.Empty);
            ShowLabel();
        }

        private void InitializeLabel(List<string> list)
        {
            enrtys = list.ToList();

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

        public void ShowLabel()
        {
            for (int i = 0; i < teamBlueLabels.Length; i++)
            {
                teamBlueLabels[i].Text = enrtys[i];
            }

            int idx = teamBlueLabels.Length;
            for (int i = 0; i < teamRedLabels.Length; i++)
            {
                teamRedLabels[i].Text = enrtys[idx];
                idx++;
            }
        }

        private Label[] teamBlueLabels;
        private Label[] teamRedLabels;
        public List<string> enrtys;

        public event EventHandler RetryRequested;
        public List<string> Entrys
        {
            get => enrtys;
            set { enrtys = value; }
        }
    }
}
