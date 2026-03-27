using Raura.Services.Parsing;
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

        public event Action? OnMainRequest;
        public event Action<List<string>>? OnMainInputRequest;

        public MnMainPresenter(MnIMainView view,IParsingService parsingService)
        {
            _view = view;
            _parsingService = parsingService;
            _view.MainRequested += OnMainInputRequested;
        }

        private void OnMainRequested(object? sender, EventArgs e)
        {
            OnMainRequest?.Invoke();
        }

        private void OnMainInputRequested(object? sender, EventArgs e)
        {
            string rawText = _view.InputPlayer;

            List<string> parsingText = _parsingService.ParseService(rawText);

            OnMainInputRequest?.Invoke(parsingText);
        }
    }
}
