using OpenQA.Selenium;

namespace OnlineMarriageSystem.POM_repo
{
    class BetweenDatesReportsPage_withoutException_
    {
        private IWebDriver driver;
        public BetweenDatesReportsPage_withoutException_(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement fromdatefield => driver.FindElement(By.Id("fromdate"));

        public IWebElement submitbutton()
        {
            return fromdatefield;
        }
    }
}
