using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;
using OnlineMarriageSystem.POM_repo;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TestProject1_nunit.Framework.Framework_GenericUtility;

namespace OnlineMarriageSystem.GenericUtility
{
    class BaseForAdmin
    {
        public IWebDriver driver;
        JsonUtility jutily = new JsonUtility();
       public ExcelFileUtility exutil = new ExcelFileUtility();
        public WebDriverUtility wbutil = new WebDriverUtility();

        ExtentReports extreport;
        ExtentTest extest;
        string nametest;
        
        [OneTimeSetUp]
        public void launchbrowser()
        {
            string launcher = jutily.ToReadfromjson("browser");
            if (launcher.Equals("ChromE", StringComparison.OrdinalIgnoreCase))
                driver = new ChromeDriver();

            else if (launcher.Equals("edgE", StringComparison.OrdinalIgnoreCase))
                driver = new EdgeDriver();

            else if (launcher.Equals("firefox", StringComparison.OrdinalIgnoreCase))
                driver = new FirefoxDriver();
            C_Utility ctil = new C_Utility();
            string path = "C:\\Users\\ranja\\source\\repos\\OnlineMarriageSystem\\OnlineMarriageSystem\\Report\\" + ctil.ForSystemDataandTime() + ".html";
            //generate blank htmlreport--
            ExtentSparkReporter sparkreport = new ExtentSparkReporter(path);
            sparkreport.Config.DocumentTitle = "MatrimonyAdminReport";
            sparkreport.Config.ReportName = "Reportmarriageonline";
            sparkreport.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Standard;
            extreport = new ExtentReports();
            //----
            extreport.AttachReporter(sparkreport);
        }
        [SetUp]
        public void navigatetowelcomepage()
        {
            wbutil.ToMaximize(driver);
            wbutil.ImplicitwaitElements(driver,6);
            SigninPage sgpg = new SigninPage(driver);
            driver.Navigate().GoToUrl(jutily.ToReadfromjson("url"));
            sgpg.LoginASADmin(jutily.ToReadfromjson("usernameadmin"), jutily.ToReadfromjson("password"));
           //related to report
            extest= extreport.CreateTest("admin");
        }
        
        [TearDown]
        public void logout()
        {
            AdminHomePage adhap = new AdminHomePage(driver);
            adhap.Admindropdown.Click();
            Thread.Sleep(2000);
            adhap.Signoutlink.Click();

            //related to report it test script fails
            string? tracestack = TestContext.CurrentContext.Result.StackTrace;
            nametest = TestContext.CurrentContext.Test.Name;
            extest.Log(Status.Info, nametest + " execution start");
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                string snapfails = ts.GetScreenshot().AsBase64EncodedString;
                extest.AddScreenCaptureFromBase64String(snapfails);
                extest.Log(Status.Fail, "test fail with log traces " + tracestack);
            }
            else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                extest.Log(Status.Pass, nametest + " test passed");
            }
            extreport.Flush();
        }
        [OneTimeTearDown]
        public void closebrowser()
        {
            driver.Dispose();
            driver.Quit();
        }
    }
}
