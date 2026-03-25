using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;

using Raura.Presenters;
using Raura.Views.StartView;
using Raura.Views.MainView;
using Raura.Views.ResultView;


namespace Raura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowStartView();
        }

        private void Load_MainScreen(object sender, EventArgs e)
        {
        }

        private void ShowStartView()
        {
            var startview = new ucStartScreen();
            var startPreenter = new MnStartPresenter(startview);

            startPreenter.OnStartRequest += () =>
            {
                ShowMainView();
            };

            ShowView(startview);
        }

        private void ShowMainView()
        {
            var MainView = new ucMainScreen();
            var MainPresenter = new MnMainPresenter(MainView);

            MainPresenter.OnMainRequest += () =>
            {
                ShowResultView();
            };

            ShowView(MainView);
        }

        private void ShowView(UserControl view)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(view);
        }

        private void ShowResultView()
        {
            var ResultView = new ucResultScreen();

            ShowView(ResultView);
        }

    }
}
