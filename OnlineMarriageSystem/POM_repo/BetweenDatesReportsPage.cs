using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
   public class BetweenDatesReportsPage
    {
        private IWebDriver driver;
        public BetweenDatesReportsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "fromdate")]
        private IWebElement fromdatefield;

        [FindsBy(How = How.Id, Using = "todate")]
        private IWebElement todatefield;

        [FindsBy(How = How.Id, Using = "submit")]
        private IWebElement submitbutton;

        public IWebElement Submitbutton { get => submitbutton; set => submitbutton = value; }
        public IWebElement Todatefield { get => todatefield; set => todatefield = value; }
        public IWebElement Fromdatefield { get => fromdatefield; set => fromdatefield = value; }

    }
}
