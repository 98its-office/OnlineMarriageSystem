using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    internal class SearchPage
    {
        public SearchPage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver,this);
        }
        [FindsBy(How = How.Name, Using = "searchdata")]
        private IWebElement searchByReg;

        [FindsBy(How =How.Id,Using = "search")]
        private IWebElement searchButton;

        [FindsBy(How =How.XPath,Using = "//tbody/tr/td[2]")]
        private IWebElement regTextField;

        public IWebElement SearchByReg { get => searchByReg; set => searchByReg = value; }
        public IWebElement SearchButton { get => searchButton; set => searchButton = value; }
        public IWebElement RegTextField { get => regTextField; set => regTextField = value; }
    }
}
