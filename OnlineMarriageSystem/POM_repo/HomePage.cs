﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    class HomePage
    {
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Registration')]")]
        private IWebElement headerwelcomepg;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'New')]")]
        private IWebElement newapplicationlink;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'id=3')]")]
        private IWebElement infoeyeicon;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Verified')]")]
        private IWebElement verifiedapplicationlink;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Rejected')]")]
        private IWebElement rejectedapplicationlink;

        [FindsBy(How = How.XPath, Using = "//span[text()='Report']")]
        private IWebElement reportlink;

        [FindsBy(How = How.XPath, Using = "//span[text()='Search']")]
        private IWebElement searchlink;

        [FindsBy(How = How.XPath, Using = "//span[text()='Admin']")]
        private IWebElement admindropdown;

        [FindsBy(How = How.PartialLinkText, Using = "Sign Out")]
        private IWebElement signoutlink;

        public IWebElement Headerwelcomepg { get => headerwelcomepg; set => headerwelcomepg = value; }
        public IWebElement Newapplicationlink { get => newapplicationlink; set => newapplicationlink = value; }
        public IWebElement Infoeyeicon { get => infoeyeicon; set => infoeyeicon = value; }
        public IWebElement Verifiedapplicationlink { get => verifiedapplicationlink; set => verifiedapplicationlink = value; }
        public IWebElement Rejectedapplicationlink { get => rejectedapplicationlink; set => rejectedapplicationlink = value; }
        public IWebElement Reportlink { get => reportlink; set => reportlink = value; }
        public IWebElement Searchlink { get => searchlink; set => searchlink = value; }
        public IWebElement Admindropdown { get => admindropdown; set => admindropdown = value; }
        public IWebElement Signoutlink { get => signoutlink; set => signoutlink = value; }
    }
}
