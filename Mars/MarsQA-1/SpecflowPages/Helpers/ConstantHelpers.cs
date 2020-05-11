using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://192.168.99.100:5000/";

        //ScreenshotPath
        public static string ScreenshotPath = @"F:\Tasks\Mars\MarsQA-1\TestReports\Screenshots\";

        //ExtentReportsPath
        public static string ReportsPath = @"F:\Tasks\Mars\MarsQA-1\TestReports\MarsReports.html";

        //ReportXML Path
        public static string ReportXMLPath = @"F:\Tasks\Mars\MarsQA-1\TestReports\ReportXML.xml";

        //Excel path
        public static string ExcelPath = @"F:\Tasks\Mars\MarsQA-1\SpecflowTests\Data\TestData.xlsx";
    }
}