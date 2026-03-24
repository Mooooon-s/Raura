using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Raura.Views.StartView;

namespace Raura.Presenters
{
    internal class MnStartPresenter
    {
        private readonly MnIStartView _view;

        public event Action? OnStartRequest;

        public MnStartPresenter(MnIStartView view)
        {
            _view = view;
            _view.StartRequested += OnStartReqested;
        }

        private void OnStartReqested(object? sender,EventArgs e)
        {
            OnStartRequest?.Invoke();
        }
    }
}
