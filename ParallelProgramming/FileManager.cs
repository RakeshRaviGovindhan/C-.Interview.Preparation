using IronPdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class FileManager
    {
        public void ReadFile()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://www.wikipedia.org/");
            pdf.SaveAs("wiki.pdf");
        }
    }
}
