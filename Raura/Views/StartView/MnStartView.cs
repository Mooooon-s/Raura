using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raura.Views.StartView
{
    internal class MnStartView
    {
        public MnStartView() {
            ucStartScreen ucStartScreen = new ucStartScreen();
        }

        public event EventHandler? StartRequested;
    }
}
