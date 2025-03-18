using OnlineMarriageSystem.GenericUtility;
using OnlineMarriageSystem.POM_repo;
using OpenQA.Selenium;

namespace OnlineMarriageSystem.TestScriptUtility
{
    class TS_01_Admin_new_appl :BaseForAdmin
    {
        [Test]
        public void applnew()
        {
            AdminHomePage hp = new AdminHomePage(driver);
        //    driver.FindElement(By.XPath(""))
            wbutil.ExplicitwaitElementsClickable(driver,By.XPath("//a[contains(text(),'New')]"),9);
            hp.Newapplicationlink.Click();
            hp.Newapplinfoeyeicon.Click();
            ViewMarriageAppPage view = new ViewMarriageAppPage(driver);

            wbutil.ScrolltoViewUsingJavaScriptExecutor(driver, view.TakeActionbutton1);
            view.TakeActionbutton1.Click();
            view.Remarkstextfield.SendKeys("rejected");
            Thread.Sleep(2000);
            wbutil.ToHandleDropdown(view.Statusdropdown, "Rejected");
            Thread.Sleep(2000);
            view.Closebutton.Click();
        }
    }
}
