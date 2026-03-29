using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raura.Views.MainView
{
    internal interface MnIMainView
    {
        string InputPlayer { get; }
        bool IsCheck { get; set; }
        event EventHandler MainRequested;
    }
}
