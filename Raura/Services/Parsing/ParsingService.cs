using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raura.Services.Parsing
{
    internal class ParsingService : IParsingService
    {
        public ParsingService()
        {

        }

        public List<string> ParseService(string rawText)
        {
            if(string.IsNullOrWhiteSpace(rawText)) return new List<string>();

            return rawText.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries)
                      .Select(s => s.Trim())
                      .ToList();
        }
    }
}
