using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    class ViewMarriageAppPage
    {
        public ViewMarriageAppPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = ("//td[contains(text(),'Husband')]"))]
        private IWebElement husbanddetailstext;

        [FindsBy(How = How.XPath, Using = "//button[text()='Take Action']")]
        private IWebElement TakeActionbutton;

        [FindsBy(How = How.XPath, Using = "//textarea[@name='remark']")]
        private IWebElement remarkstextfield;

        [FindsBy(How = How.XPath, Using = "//select[@required='true']")]
        private IWebElement statusdropdown;

        [FindsBy(How = How.XPath, Using = "//button[text()='Close']")]
        private IWebElement closebutton;

        [FindsBy(How = How.XPath, Using = "//button[text()='Update']")]
        private IWebElement updatebutton;

        public IWebElement TakeActionbutton1 { get => TakeActionbutton; set => TakeActionbutton = value; }
        public IWebElement Remarkstextfield { get => remarkstextfield; set => remarkstextfield = value; }
        public IWebElement Statusdropdown { get => statusdropdown; set => statusdropdown = value; }
        public IWebElement Closebutton { get => closebutton; set => closebutton = value; }
        public IWebElement Updatebutton { get => updatebutton; set => updatebutton = value; }
        public IWebElement Husbanddetailstext { get => husbanddetailstext; set => husbanddetailstext = value; }
    }
}
