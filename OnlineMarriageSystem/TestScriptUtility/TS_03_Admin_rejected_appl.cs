using OnlineMarriageSystem.GenericUtility;
using OnlineMarriageSystem.POM_repo;
using OpenQA.Selenium;

namespace OnlineMarriageSystem.TestScriptUtility
{
    class TS_03_Admin_rejected_appl : BaseForAdmin
    {
        [Test]
        public void applrejected()
        {
            AdminHomePage admhpg = new AdminHomePage(driver);
            wbutil.ExplicitwaitElementsClickable(driver, By.XPath("//a[contains(text(),'Rejected')]"),8);
            admhpg.Rejectedapplicationlink.Click();
            admhpg.Rejectedmarriageeyeicon.Click();
            Assert.Fail();
            ViewMarriageAppPage viewm = new ViewMarriageAppPage(driver);
            wbutil.ScrolltoViewUsingJavaScriptExecutor(driver, viewm.Husbanddetailstext);
        }
    }
}
