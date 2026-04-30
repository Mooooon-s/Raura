using OpenCvSharp;
using OpenCvSharp.Extensions;
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
using System.IO;
using System.Windows;

namespace Raura.Views.ResultView
{
    public partial class ucResultScreen : UserControl, MnIResultView
    {
        public ucResultScreen(List<string> list,bool Israndom)
        {
            InitializeComponent();
            InitializeLabel(list);
            if(Israndom)
                _=InitializePics();
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

        private async Task InitializePics()
        {
            string[] roll = { "TOP", "JUNGLE", "MID", "BOT", "SUP" };

            TeamBluePics = new[] { TOP_B, JUNGLE_B, MID_B, BOT_B, SUP_B };
            TeamRedPics = new[] { TOP_R, JUNGLE_R, MID_R, BOT_R, SUP_R };

            for (int i = 0; i < roll.Length; i++)
            {
                Bitmap icon = await Task.Run(()=> LoadIcon($"{roll[i]}.png"));

                TeamBluePics[i].Image = icon;
                TeamRedPics[i].Image = icon;
            }
        }


        public void ShowLabel()
        {
            int idx = teamBlueLabels.Length;
            for (int i = 0; i < teamBlueLabels.Length; i++)
            {
                teamBlueLabels[i].Text = enrtys[i];
                teamRedLabels[i].Text = enrtys[idx];
                idx++;
            }

            Clipboard.SetText(MakeClipBoardString());
        }

        public Bitmap LoadIcon(string iconName)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource", iconName);
            Mat Icon = Cv2.ImRead(filePath);
            Bitmap iconBitmap = BitmapConverter.ToBitmap(Icon);
            iconBitmap.MakeTransparent();
            Icon.Dispose();
            return iconBitmap;
        }

        private string MakeClipBoardString()
        {
            string s = "TeamBlue: ";
            for (int i = 0; i< Entrys.Count; i++)
            {
                s += Entrys[i];
                s += " ";
                if(i == 4)
                    s += "\nTeamRed: ";
            }
            return s;
        }

        private Label[] teamBlueLabels;
        private Label[] teamRedLabels;

        private PictureBox[] TeamBluePics;
        private PictureBox[] TeamRedPics;

        public List<string> enrtys;

        public event EventHandler RetryRequested;
        public List<string> Entrys
        {
            get => enrtys;
            set { enrtys = value; }
        }
    }
}
