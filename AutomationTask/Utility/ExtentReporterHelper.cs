using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using System;
using System.IO;

namespace AutomationTask.Utility
{
    public static class ExtentReporterHelper
    {
        private static ExtentReports extent;
        private static ExtentTest test;

        public static void InitReport()
        {
            if (extent != null) return;

            string reportPath = Path.Combine(
                TestContext.CurrentContext.WorkDirectory,
                "Reports",
                "ExtentReport.html"
            );

            Directory.CreateDirectory(Path.GetDirectoryName(reportPath));

            var spark = new ExtentSparkReporter(reportPath);
            spark.Config.DocumentTitle = "Automation Test Report for Daraz";
            spark.Config.ReportName = "Selenium NUnit Execution Report for Daraz";

            extent = new ExtentReports();
            extent.AttachReporter(spark);

            extent.AddSystemInfo("OS", Environment.OSVersion.ToString());
            extent.AddSystemInfo("Framework", "NUnit");
            extent.AddSystemInfo("Runtime", ".NET 6");
        }

        public static ExtentTest CreateTest(string testName)
        {
            test = extent.CreateTest(testName);
            return test;
        }

        public static ExtentTest GetTest()
        {
            return test;
        }

        public static void FlushReport()
        {
            extent.Flush();
        }
    }
}
