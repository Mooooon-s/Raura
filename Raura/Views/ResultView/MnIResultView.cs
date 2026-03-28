using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raura.Views.ResultView
{
    internal interface MnIResultView
    {
        List<string> Entrys { get; set; }
        event EventHandler RetryRequested;
    }
}
