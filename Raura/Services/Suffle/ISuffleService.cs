using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raura.Services.Suffle
{
    internal interface ISuffleService
    {
        List<string> SufflingService(List<string> parsingtext);
    }
}
