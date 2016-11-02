using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace tarea
{
    class FacturaPDF
    {
        //Atributo el cual extrae la fecha del sistema 
        DateTime thisDay = DateTime.Today;
        //Atributos para generar PDF 
        public void crearFacturaPDF()
        {
            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);

            graph.DrawString("This is my first PDF document  ", font, XBrushes.Black,
            new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("This is my second PDF document ", font, XBrushes.Black,
            new XRect(0, 40, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString("This is my last PDF document", font, XBrushes.Black,
            new XRect(0, 80, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            pdf.Save("C:\\Users\\andres\\Desktop\\prueba.pdf");
        }
    }
}
