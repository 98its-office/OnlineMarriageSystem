using OnlineMarriageSystem.GenericUtility;
using OnlineMarriageSystem.POM_repo;

namespace OnlineMarriageSystem.TestScriptUtility
{
    class TS_04_Admin_Report : BaseForAdmin
    {
        [Test]
        public void viewreport()
        {
            AdminHomePage adhmpg = new AdminHomePage(driver);
            wbutil.ImplicitwaitElements(driver, 9);
            adhmpg.Reportlink.Click();
            BetweenDatesReportsPage betreportpg = new BetweenDatesReportsPage(driver);
            string fromdate = exutil.ToreadfromExcel("ReportDate", 1, 2);
            string todate = exutil.ToreadfromExcel("ReportDate", 2, 2);
            betreportpg.Fromdatefield.SendKeys(fromdate);
            betreportpg.Todatefield.SendKeys(todate);
            betreportpg.Submitbutton.Click();

        }
    }
}
