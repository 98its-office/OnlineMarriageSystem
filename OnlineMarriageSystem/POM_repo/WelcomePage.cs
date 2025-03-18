using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    class WelcomePage
    {
        public WelcomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.PartialLinkText, Using = "Admin")]
        private IWebElement adminlink;

        [FindsBy(How = How.XPath, Using = "//a[@href='user/login.php']")]
        private IWebElement userLink;


        public IWebElement Adminlink { get => adminlink; set => adminlink = value; }
        public IWebElement UserLink { get => userLink; set => userLink = value; }
    }
}
