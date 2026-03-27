using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Raura.Services.Suffle
{
    internal class SuffleService : ISuffleService
    {
        public List<string> SufflingService(List<string> parsingtext)
        {
            var result = parsingtext.ToList();
            int n = result.Count;
            while (n > 1)
            {
                n--;
                int k = RandomNumberGenerator.GetInt32(n + 1);

                string value = result[k];
                result[k] = result[n];
                result[n] = value;
            }
            return result;
        }
    }
}
