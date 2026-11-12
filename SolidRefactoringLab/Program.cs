using System;

namespace SolidRefactoringLab
{
    class Program
    {
        public static void Main(string[] args)
        {
            IReportFormatter formatter = new PdfFormatter();

            ReportManager manager = new ReportManager(formatter);
            manager.GenerateReport("PDF");

            ReportSaver saver = new ReportSaver();
            saver.SaveToFile("Q1_Report.pdf");
        }
    }
}