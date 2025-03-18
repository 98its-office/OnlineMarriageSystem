using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace OnlineMarriageSystem.GenericUtility
{
    class BaseForAdmin : BaseforUser
    {
        [OneTimeSetUp]
        public void launchbrowser()
        {
            string launcher = js.ToReadfromjson("browser");
            if (launcher.Equals("ChromE", StringComparison.OrdinalIgnoreCase))
                driver = new ChromeDriver();

            else if (launcher.Equals("edgE", StringComparison.OrdinalIgnoreCase))
                driver = new EdgeDriver();

            else if (launcher.Equals("firefox", StringComparison.OrdinalIgnoreCase))
                driver = new FirefoxDriver();
        }
        [SetUp]
        public void navigatetoadminpage()
        {
            
        }
    }
}
