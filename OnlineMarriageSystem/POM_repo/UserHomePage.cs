using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    internal class UserHomePage
    {
        public UserHomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How = How.XPath, Using = "//a[text()='Online Marriage Registration System']")]
        private IWebElement header;

        [FindsBy(How =How.LinkText, Using = "Registration Form")]
        private IWebElement registrationLink;

        [FindsBy(How =How.LinkText, Using = "View Marriage Application")]
        private IWebElement marraigeApplication;

        [FindsBy(How=How.LinkText,Using = "Search")]
        private IWebElement searchLink;

        //[FindsBy(How =How.XPath, Using = "//img[@src='img/images.png']")]
        //private IWebElement userIcon;

        [FindsBy(How=How.XPath, Using = "href=\"logout.php\"")]
        private IWebElement logoutButton;

        public IWebElement Header { get => header; set => header = value; }
        public IWebElement RegistrationLink { get => registrationLink; set => registrationLink = value; }
        public IWebElement MarraigeApplication { get => marraigeApplication; set => marraigeApplication = value; }
        public IWebElement SearchLink { get => searchLink; set => searchLink = value; }
        //public IWebElement UserIcon { get => userIcon; set => userIcon = value; }
        public IWebElement LogoutButton { get => logoutButton; set => logoutButton = value; }

        //Businnes Library
        public void LogoutAsUser() 
        { 
           // UserIcon.Click();
            LogoutButton.Click();
        }
    }
}
