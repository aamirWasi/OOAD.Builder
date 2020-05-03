using System;

namespace OOD.dotnetBuildertuts
{
    class Program
    {
        static void Main(string[] args)
        {
            var builderPDF = new ReportBuilder();
            builderPDF.SetReportType("PDF");
            builderPDF.SetReportHeader("PDF Header Section");
            builderPDF.SetReportContent("PDF Content Section");
            builderPDF.SetReportFooter("PDF Footer Section");
            var orderPDF = builderPDF.GetReport();
            orderPDF.DisplayReport();
            var builderExecl = new ReportBuilder();
            builderExecl.SetReportType("Excel");
            builderExecl.SetReportHeader("Excel Header Section");
            builderExecl.SetReportContent("Excel Content Section");
            builderExecl.SetReportFooter("Excel Footer Section");
            var orderExcel = builderExecl.GetReport();
            orderExcel.DisplayReport();
        }
    }
}
