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
    public class BaseforUser
    {
       public IWebDriver driver;
       internal WebDriverUtility web= new WebDriverUtility();
       internal ExcelFileUtility ex=new ExcelFileUtility();
       internal JsonUtility js= new JsonUtility();
       internal C_Utility c=new C_Utility();
        ExtentReports extent;
        SigninPage sp;
        UserHomePage uhp;
        ExtentTest test;
        string testName;

        [OneTimeSetUp]
        public void LaunchBrowser() 
        {
            Console.WriteLine("Connect To Data Base");
            string Browser=js.ToReadfromjson("browser");
            if (Browser.Equals("chrome", StringComparison.OrdinalIgnoreCase))
            {
                driver = new ChromeDriver();
            }
            else if (Browser.Equals("firefox",StringComparison.OrdinalIgnoreCase))
            {
                driver = new FirefoxDriver();
            }
            else if(Browser.Equals("edge", StringComparison.OrdinalIgnoreCase))
            {
                driver = new EdgeDriver();
            }

            web.ToMaximize(driver);
            driver.Url = js.ToReadfromjson("url");
            web.ImplicitwaitElements(driver);
            SigninPage s = new SigninPage(driver);
            s.UserLink.Click();

            //extent report
            string path = "C:\\Users\\HP\\Source\\Repos\\OnlineMarriageSystemNew\\OnlineMarriageSystem\\Report\\" + c.ForSystemDataandTime() + ".html";
            ExtentSparkReporter htmlreporter=new ExtentSparkReporter(path);
            htmlreporter.Config.DocumentTitle = "MarraigeAppTestReport";
            htmlreporter.Config.ReportName = "TestScripReport";
            htmlreporter.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Dark;
            extent= new ExtentReports();
            extent.AttachReporter(htmlreporter);
           }
           [SetUp]
            public void LoginToAppUser()
            {
             string userType = js.ToReadfromjson("module");
            //Console.WriteLine("enter user type");
            //string userType = Console.ReadLine();
            sp = new SigninPage(driver);
            if (userType.Equals("user", StringComparison.OrdinalIgnoreCase))
            {
                sp.LoginAsUser(js.ToReadfromjson("usernameuser"), js.ToReadfromjson("password"));
            }
            else if(userType.Equals("admin",StringComparison.OrdinalIgnoreCase)) 
            {
                sp.LoginASADmin(js.ToReadfromjson("usernameadmin"),js.ToReadfromjson("password"));
                
            }
            test = extent.CreateTest("Reg");
        }
        [TearDown]
        public void LogoutUser()
        {
            var stackTrace = TestContext.CurrentContext.Result.StackTrace;
            testName = TestContext.CurrentContext.Test.Name;
            test.Log(Status.Info, testName + " start execution");
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
            {
                ITakesScreenshot ts = (ITakesScreenshot)driver;
                string screenshot = ts.GetScreenshot().AsBase64EncodedString;
                test.AddScreenCaptureFromBase64String(screenshot);
                test.Log(Status.Fail, "Test fail with log trace ---" + stackTrace + " " + c.ForSystemDataandTime());
            }
            else if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Passed)
            {
                test.Log(Status.Pass, testName + " test passed " + c.ForSystemDataandTime());
            }
            extent.Flush();
            uhp =new UserHomePage(driver);
            uhp.LogoutAsUser();
        }
        [OneTimeTearDown]
        public void CloseBrowser() 
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}
