using Raura.Services.Parsing;
using Raura.Services.Suffle;
using Raura.Views.MainView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raura.Presenters
{
    internal class MnMainPresenter
    {
        public readonly MnIMainView _view;
        public readonly IParsingService _parsingService;
        public readonly ISuffleService _suffleService;

        public event Action? OnMainRequest;
        public event Action<List<string>>? OnMainInputRequest;

        public MnMainPresenter(MnIMainView view,IParsingService parsingService,ISuffleService suffleService)
        {
            _view = view;
            _parsingService = parsingService;
            _suffleService = suffleService;
            _view.MainRequested += OnMainInputRequested;
        }

        private void OnMainRequested(object? sender, EventArgs e)
        {
            OnMainRequest?.Invoke();
        }

        private void OnMainInputRequested(object? sender, EventArgs e)
        {
            string rawText = _view.InputPlayer;

            //Text parsing to List
            List<string> parsingText = _parsingService.ParseService(rawText);

            //check 10 player
            if (parsingText.Count != 10)
            {
                MessageBox.Show($"please entry 10 Player......\nCurrent Player: {parsingText.Count}");
                return;
            }

            //suffle List
            var suffledText = _suffleService.SufflingService(parsingText);

            OnMainInputRequest?.Invoke(suffledText);
        }

        public void DeleteEvent()
        {
            _view.MainRequested -= OnMainInputRequested;
        }
    }
}
