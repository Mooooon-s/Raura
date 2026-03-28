using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;

using Raura.Presenters;
using Raura.Views.StartView;
using Raura.Views.MainView;
using Raura.Views.ResultView;
using Raura.Services.Parsing;
using Raura.Services.Suffle;


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
            var ParsingService = new ParsingService();
            var SuffleService = new SuffleService();
            var MainPresenter = new MnMainPresenter(MainView,ParsingService,SuffleService);

            var s = MainView.IsCheck;

            MainPresenter.OnMainInputRequest += (suffledText) =>
            {
                ShowResultView(suffledText,MainView.IsCheck);
            };

            ShowView(MainView);
        }

        private void ShowView(UserControl view)
        {
            view.Dock= DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(view);
        }

        private void ShowResultView(List<string> results,bool ischeck)
        {
            var ResultView = new ucResultScreen(results,ischeck);
            var suffleService = new SuffleService();
            var ResultPresenter = new MnResultPresenter(ResultView,suffleService);

            ShowView(ResultView);
        }

    }
}
