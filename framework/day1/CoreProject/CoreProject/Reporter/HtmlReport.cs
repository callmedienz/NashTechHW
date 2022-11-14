using AventStack.ExtentReports;
using AventStack.ExtentReports.MarkupUtils;
using AventStack.ExtentReports.Reporter;
using CoreProject.DriverCore.APICore;
using CoreProject.Reporter.ExtentMarkup;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProject.Reporter
{
    internal class HtmlReport
    {
        private static int testCaseIndex;
        private static ExtentReports _report;
        private static ExtentTest extentTestSuite;
        private static ExtentTest extentTestCase;
        public static ExtentReports createReport()
        {
            if (_report == null)
            {
                _report = createInstance();
            }
            return _report;
        }
        private static ExtentReports createInstance()
        {
            HtmlReportDirectory.InitReportDirection();
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(HtmlReportDirectory.REPORT_FILE_PATH);
            htmlReporter.Config.DocumentTitle = "Automation Test Report";
            htmlReporter.Config.ReportName = "Automation Test Report";
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            htmlReporter.Config.Encoding = "UTF-8";

            ExtentReports report = new ExtentReports();
            report.AttachReporter(htmlReporter);
            return report;

        }
        public static void flush()
        {
            if (_report != null)
            {
                _report.Flush();
            }

        }
        public static ExtentTest createTest(string className, string classDescription = "")
        {
            if (_report == null)
            {
                _report = createInstance();
            }
            extentTestSuite = _report.CreateTest(className, classDescription);

            return extentTestSuite;
        }
        public static ExtentTest createNode(string className, string testCase, string description = "")
        {

            if (extentTestSuite == null)
            {
                extentTestSuite = createTest(className);
            }

            extentTestCase = extentTestSuite.CreateNode(testCase, description);

            return extentTestCase;
        }
        public static ExtentTest GetParent()
        {
            return extentTestSuite;
        }
        public static ExtentTest GetNode()
        {
            return extentTestCase;
        }
        public static ExtentTest GetTest()
        {
            if (GetNode() == null)
            {
                return GetParent();
            }
            return GetNode();
        }
        public static void Pass(string des)
        {
            GetTest().Pass(MarkupHelper.CreateLabel(des, ExtentColor.Green));
        }
        public static void Fail(string des)
        {
            GetTest().Fail(des);
            TestContext.WriteLine(des);
        }
        public static void Fail(string des, string path)
        {
            GetTest().Fail(des).AddScreenCaptureFromPath(path);
            TestContext.WriteLine(des);
        }
        public static void Fail(string des, string ex, string path)
        {
            GetTest().Fail(des).Fail(ex).AddScreenCaptureFromPath(path);
            TestContext.WriteLine(des);
        }
        public static void Info(string des)
        {
            GetTest().Info(des);
            TestContext.WriteLine(des);
        }
        public static void Warning(string des)
        {
            GetTest().Warning(des);
            TestContext.WriteLine(des);
        }
        public static void Skip(string des)
        {
            GetTest().Skip(des);
            TestContext.WriteLine(des);
        }
        public static void MarkUpJson()
        {
            var json = "{'name':'daongochuy', dob:'17/03/2001', 'school':Greenwich}";
            GetTest().Info(MarkupHelper.CreateCodeBlock(json, CodeLanguage.Json));
        }

        public static void MarkUpTable()
        {
            string[][] table = new string[][] { new string[]
            { "ID", "Name", "Des" },
            new string[]
            { "01", "aloalo1234", "daongochuy" },
            new string[]
            { "02", "test api", "test content" }
            };
            GetTest().Info(MarkupHelper.CreateTable(table));
        }
        public static void CreateAPIRequestLog(APIRequest request, APIResponse response)
        {
            GetTest().Info(MarkupHelperPlus.CreateAPIRequestLog(request, response));
        }

    }
}
