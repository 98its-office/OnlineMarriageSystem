using OnlineMarriageSystem.GenericUtility;
using OnlineMarriageSystem.POM_repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarriageSystem.TestScriptUtility
{
    class TS_05_Admin_Search : BaseForAdmin
    {
        [Test]
        public void find()
        {
            wbutil.ImplicitwaitElements(driver, 8);
            AdminHomePage admhpg = new AdminHomePage(driver);
            admhpg.Searchlink.Click();

            SearchMarriageAppPage searmarrapp = new SearchMarriageAppPage(driver);
            searmarrapp.SearchbyRegnotextfield.SendKeys(exutil.ToreadfromExcel("RegNumToSearch", 1, 2));
            searmarrapp.Submitbutton.Click();
        }
    }
}
