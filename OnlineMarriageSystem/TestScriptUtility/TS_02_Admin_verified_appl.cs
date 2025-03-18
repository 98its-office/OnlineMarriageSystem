using OnlineMarriageSystem.GenericUtility;
using OnlineMarriageSystem.POM_repo;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarriageSystem.TestScriptUtility
{
    class TS_02_Admin_verified_appl : BaseForAdmin
    {
        [Test]
        public void applverify()
        {
            wbutil.ExplicitwaitElementsClickable(driver, By.XPath("//a[contains(text(),'Verified')]"),8);
            AdminHomePage adhp = new AdminHomePage(driver);
            ViewMarriageAppPage viewpage = new ViewMarriageAppPage(driver);
            adhp.Verifiedapplicationlink.Click();
            adhp.Verifiedmarriageeyeicon.Click();
            wbutil.ScrolltoViewUsingJavaScriptExecutor(driver, viewpage.Husbanddetailstext);
        }
    }
}
