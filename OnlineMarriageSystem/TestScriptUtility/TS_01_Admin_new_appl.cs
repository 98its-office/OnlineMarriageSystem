using OnlineMarriageSystem.GenericUtility;
using OnlineMarriageSystem.POM_repo;
using OpenQA.Selenium;
using TestProject1_nunit.Framework.Framework_GenericUtility;

namespace OnlineMarriageSystem.TestScriptUtility
{
    class TS_01_Admin_new_appl :BaseforUser
    {
        [Test]
        public void applnew()
        {
            WebDriverUtility webutil = new WebDriverUtility();
            HomePage hp = new HomePage(driver);
        //    driver.FindElement(By.XPath(""))
            webutil.ExplicitwaitElementsClickable(driver,By.XPath("//a[contains(text(),'New')]"));
            hp.Newapplicationlink.Click();
            hp.Infoeyeicon.Click();
            ViewMarriageAppPage view = new ViewMarriageAppPage(driver);
            
            webutil.ScrolltoViewUsingJavaScriptExecutor(driver, view.TakeActionbutton1);
            view.TakeActionbutton1.Click();
            view.Remarkstextfield.SendKeys("rejected");
            webutil.ToHandleDropdown(view.Statusdropdown, "Rejected");
            view.Closebutton.Click();
        }
    }
}
