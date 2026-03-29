using Raura.Services.Suffle;
using Raura.Views.ResultView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raura.Presenters
{
    internal class MnResultPresenter
    {
        public readonly MnIResultView _view;
        public readonly ISuffleService _suffleService;

        public event Action? RetryRequested;
        public event Action<List<string>>? OnRetryRequested;

        public MnResultPresenter(MnIResultView view,ISuffleService suffleService)
        {
            _view = view;
            _suffleService = suffleService;
            _view.RetryRequested += OnRetryRequest;
        }

        private void OnRetryRequest(object? sender,EventArgs e)
        {
            var suffledEnrty = _suffleService.SufflingService(_view.Entrys);

            _view.Entrys.Clear();
            _view.Entrys.AddRange(suffledEnrty);
        }
    }
}
