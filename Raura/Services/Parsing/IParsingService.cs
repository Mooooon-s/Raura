using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raura.Services.Parsing
{
    internal interface IParsingService
    {
        List<string> ParseService(string rawText);
    }
}
