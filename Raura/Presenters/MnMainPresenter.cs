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

        public event Action? OnMainRequest;

        public MnMainPresenter(MnIMainView view)
        {
            _view = view;
            _view.MainRequested += OnMainRequested;
        }

        private void OnMainRequested(object? sender, EventArgs e)
        {
            OnMainRequest?.Invoke();
        }
    }
}
