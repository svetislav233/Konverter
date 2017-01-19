using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace CirilicaULatinicu
{
    class PDFCitac
    {

        private string GetTextFromPDF()
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader("D:\\RentReceiptFormat.pdf"))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            return text.ToString();
        }
        //Step 1: Download itextsharp assembly from below URL. 
        //Just extract it (itextsharp-dll-core) and add reference (iTextSharp.dll) to project. http://sourceforge.net/projects/itextsharp/.
        //using TextSharp.text;   
        //using iTextSharp.text.pdf;  
        //using iTextSharp.text.pdf.parser;
    }
}
