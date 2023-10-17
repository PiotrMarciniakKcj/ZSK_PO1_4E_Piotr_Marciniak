using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project01.shared.Entities;

namespace Project01.shared.Interfaces
{
    internal interface ITextAnalyzerService
    {
        public TextAnalyzeResult PerformAnalysis(string text);
    }
}
