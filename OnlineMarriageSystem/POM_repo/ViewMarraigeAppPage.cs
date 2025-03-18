using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    internal class ViewMarraigeAppPageUs
    {
        public ViewMarraigeAppPageUs(IWebDriver driver) 
        { 
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How = How.XPath, Using = "//h6[text()='Verified Marriage Application']")]
        private IWebElement header;

        [FindsBy(How =How.XPath, Using = "//tbody/tr/td[2]")]
        private IWebElement regisNo;

        [FindsBy(How =How.XPath,Using = "//tbody/tr/td[3]")]
        private IWebElement name;

        [FindsBy(How =How.XPath,Using = "//tbody/tr/td[4]")]
        private IWebElement marraigeDate;

        [FindsBy(How =How.XPath,Using = "//tbody/tr/td[5]")]
        private IWebElement regStatus;

        public IWebElement Header { get => header; set => header = value; }
        public IWebElement RegisNo { get => regisNo; set => regisNo = value; }
        public IWebElement MarraigeDate { get => marraigeDate; set => marraigeDate = value; }
        public IWebElement Name { get => name; set => name = value; }
        public IWebElement RegStatus { get => regStatus; set => regStatus = value; }
    }
}
