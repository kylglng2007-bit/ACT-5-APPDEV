public class ReportManager
    {
        private readonly IReportFormatter _reportFormatter;
        public string ReportData { get; set; }

        public ReportManager(IReportFormatter reportFormatter)
        {
            _reportFormatter = reportFormatter;
        }

        public void GenerateReport(string reportType)
        {
            _reportFormatter.FormatReport();
        }
    }