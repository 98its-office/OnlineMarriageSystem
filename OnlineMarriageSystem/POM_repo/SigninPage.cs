using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    class SigninPage
    {
        public SigninPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using="//input[@type='text']")]
        private IWebElement usernametextfieldadmin;

        [FindsBy(How = How.XPath, Using="//input[@type='password']")]
        private IWebElement passwordtextfieldadmin;

        [FindsBy(How = How.XPath, Using="//button[@type='submit']")]
        private IWebElement signinbuttonadmin;
        public void LoginASADmin(string usernameU, string passwordU)
        {
            adminLink.Click();
            usernametextfieldadmin.SendKeys(usernameU);
            passwordtextfieldadmin.SendKeys(passwordU);
            signinbuttonadmin.Click();
        }
        public void LoginAsUser(string usernameU, string passwordU)
        {
            
            usernameTextFieldUser.SendKeys(usernameU);
            passwordtextfieldUser.SendKeys(passwordU);
            userSubmitButton.Click();

        }
        [FindsBy(How = How.XPath, Using = "//a[@href='user/login.php']")]
        private IWebElement userLink;

        [FindsBy(How = How.Name, Using = "mobno")]
        private IWebElement usernameTextFieldUser;

        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passwordtextfieldUser;

        [FindsBy(How = How.Name, Using = "login")]
        private IWebElement userSubmitButton;
        [FindsBy(How = How.XPath, Using = "//a[@href='admin/login.php']")]
        private IWebElement adminLink;
        public IWebElement Usernametextfield { get => usernametextfieldadmin; }
        public IWebElement Passwordtextfield { get => passwordtextfieldadmin;  }
        public IWebElement Signinbutton { get => signinbuttonadmin; }
        public IWebElement UserLink { get => userLink; set => userLink = value; }
    }
}
