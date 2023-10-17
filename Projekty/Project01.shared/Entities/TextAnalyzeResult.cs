using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project01.shared.Entities
{
    public class TextAnalyzeResult
    {
        public string? textLength { get; set; }
        public bool? containsLetters { get; set; }
        public bool? containsNumbers { get; set; }
        public bool? containsSymbols { get; set; }

    }
}
