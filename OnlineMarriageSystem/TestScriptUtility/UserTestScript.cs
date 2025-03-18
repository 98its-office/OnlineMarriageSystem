using OnlineMarriageSystem.GenericUtility;
using OnlineMarriageSystem.POM_repo;
using TestProject1_nunit.Framework.Framework_GenericUtility;

namespace OnlineMarriageSystem.TestScriptUtility
{
    internal class UserTestScript:BaseforUser
    {
        [Test]
        public void Registration()
        {
            UserHomePage uhp=new UserHomePage(driver);
            uhp.RegistrationLink.Click();
            UserRegistrationPage rp=new UserRegistrationPage(driver);
            rp.DateOfMarraigeTextField.SendKeys(ex.ToreadfromExcel("Husb", 2, 1));
            rp.HusbandNameTextField.SendKeys(ex.ToreadfromExcel("Husb", 2, 2));
            rp.HImage.SendKeys(IPathConstants.husbImagePath);
            rp.HusbandReligionTextField.SendKeys(ex.ToreadfromExcel("Husb", 2, 3));
            rp.HDobTextField.SendKeys(ex.ToreadfromExcel("Husb", 2, 4));
            web.ToHandleDropdown(rp.HMarrStatus, "Bachelor");
            rp.HAddTextField.SendKeys(ex.ToreadfromExcel("Husb", 2, 5));
            rp.HZipCodeTextField.SendKeys(ex.ToreadfromExcel("Husb", 2, 6));
            rp.HStateTextField.SendKeys(ex.ToreadfromExcel("Husb", 2, 7));
            rp.HAadharTextField.SendKeys(ex.ToreadfromExcel("Husb", 2, 8));
            rp.WNameTextField.SendKeys(ex.ToreadfromExcel("wife", 2, 2));
            rp.WImage.SendKeys(IPathConstants.wifImagePath);
            rp.WReligionTextField.SendKeys(ex.ToreadfromExcel("wife", 2, 3));
            rp.WDobTextField.SendKeys(ex.ToreadfromExcel("wife", 2, 4));
            web.ToHandleDropdown(rp.WMarrStatus, "Bachelor");
            rp.WAddTextField.SendKeys(ex.ToreadfromExcel("wife", 2, 5));
            rp.WZipCodeTextField.SendKeys(ex.ToreadfromExcel("wife", 2, 6));
            rp.WStateTextField.SendKeys(ex.ToreadfromExcel("wife", 2, 7));
            rp.WAadharTextField.SendKeys(ex.ToreadfromExcel("wife", 2, 8));
            rp.FirstWittNameTextField.SendKeys(ex.ToreadfromExcel("wittness", 2, 1));
            rp.FisrtWittAddTextField.SendKeys(ex.ToreadfromExcel("wittness", 2, 2));
            rp.SecondWittNameTextField.SendKeys(ex.ToreadfromExcel("wittness", 2, 3));
            rp.SecWittAddTextField.SendKeys(ex.ToreadfromExcel("wittness", 2, 4));
            rp.ThirdWittNameTextField.SendKeys(ex.ToreadfromExcel("wittness", 2, 5));
            rp.ThirdWittAddTextField.SendKeys(ex.ToreadfromExcel("wittness", 2, 6));
            web.ScrolltoViewUsingJavaScriptExecutor(driver,rp.SubmitButton);
            rp.SubmitButton.Click();

        }
    }
}
