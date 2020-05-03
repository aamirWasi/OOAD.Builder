namespace OOD.dotnetBuildertuts
{
    public class ReportBuilder
    {
        private readonly Report _order;

        public ReportBuilder()
        {
            _order = new Report(); 
        }
        public void SetReportType(string message)
        {
            _order.ReportType = message;
        }
        public void SetReportContent(string message)
        {
            _order.ReportContent = message;
        }
        public void SetReportFooter(string message)
        {
            _order.ReportFooter = message;
        }
        public void SetReportHeader(string message)
        {
            _order.ReportHeader = message;
        }
        public Report GetReport()
        {
            return _order;
        }
    }
}
