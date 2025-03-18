using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace OnlineMarriageSystem.GenericUtility
{
    class Outputscr
    {
        IWebDriver driver;
        [Test]
        public void tolaunch()
        {
            Console.WriteLine("enter browser name");
            string browname = Console.ReadLine();
            if (browname.Equals("chrome", StringComparison.OrdinalIgnoreCase))
                driver = new ChromeDriver();
            else if (browname.Equals("edge", StringComparison.OrdinalIgnoreCase))
                driver = new EdgeDriver();
            else if (browname.Equals("firefox", StringComparison.OrdinalIgnoreCase))
                driver = new FirefoxDriver();
        }
        [TearDown]
        public void close()
        {
            Thread.Sleep(3000);
            driver.Dispose(); driver.Quit();
        }
    }
}
