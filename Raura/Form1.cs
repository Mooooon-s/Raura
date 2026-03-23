using OpenCvSharp;
using OpenCvSharp.Extensions;
using Raura.Views.StartView;
using System;
using System.Drawing;

namespace Raura
{
    public partial class Form1 : Form
    {
        ucStartScreen startScreen = new ucStartScreen();

        public Form1()
        {
            InitializeComponent();
        }

        private void Load_MainScreen(object sender, EventArgs e)
        {
            panel1.Controls.Add(startScreen);
        }
    }
}
