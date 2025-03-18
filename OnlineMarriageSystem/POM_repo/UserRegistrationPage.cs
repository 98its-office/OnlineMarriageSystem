using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace OnlineMarriageSystem.POM_repo
{
    internal class UserRegistrationPage
    {
        public UserRegistrationPage(IWebDriver driver) 
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "dom")]
        private IWebElement dateOfMarraigeTextField;

        [FindsBy(How=How.Name,Using = "nofhusband")]
        private IWebElement husbandNameTextField;

        [FindsBy(How = How.Name, Using = "husimage")]
        private IWebElement hImage;

        [FindsBy(How =How.Name,Using = "hreligion")]
        private IWebElement husbandReligionTextField;

        [FindsBy(How =How.Id, Using = "hdob")]
        private IWebElement hDobTextField;

        [FindsBy(How = How.Name, Using = "hsbmarriage")]
        private IWebElement hMarrStatus;

        [FindsBy(How=How.Name,Using = "haddress")]
        private IWebElement hAddTextField;

        [FindsBy(How =How.Name, Using = "hzipcode")]
        private IWebElement hZipCodeTextField;

        [FindsBy(How =How.Name,Using = "hstate")]
        private IWebElement hStateTextField;

        [FindsBy(How =How.Name,Using = "hadharno")]
        private IWebElement hAadharTextField;


        [FindsBy(How = How.Name, Using = "nofwife")]
        private IWebElement wNameTextField;

        [FindsBy(How = How.Name, Using = "wifeimage")]
        private IWebElement wImage;

        [FindsBy(How = How.Name, Using = "wreligion")]
        private IWebElement wReligionTextField;

        [FindsBy(How = How.Id, Using = "wdob")]
        private IWebElement wDobTextField;

        [FindsBy(How = How.Name, Using = "wsbmarriage")]
        private IWebElement wMarrStatus;

        [FindsBy(How = How.Name, Using = "waddress")]
        private IWebElement wAddTextField;

        [FindsBy(How = How.Name, Using = "wzipcode")]
        private IWebElement wZipCodeTextField;

        [FindsBy(How = How.Name, Using = "wstate")]
        private IWebElement wStateTextField;

        [FindsBy(How = How.Name, Using = "wadharno")]
        private IWebElement wAadharTextField;

        [FindsBy(How = How.Name, Using = "witnessnamef")]
        private IWebElement firstWittNameTextField;


        [FindsBy(How = How.Name, Using = "waddressfirst")]
        private IWebElement fisrtWittAddTextField;

        [FindsBy(How = How.Name, Using = "witnessnames")]
        private IWebElement secondWittNameTextField;


        [FindsBy(How = How.Name, Using = "waddresssec")]
        private IWebElement secWittAddTextField;

        [FindsBy(How = How.Name, Using = "witnessnamet")]
        private IWebElement thirdWittNameTextField;


        [FindsBy(How = How.Name, Using = "waddressthird")]
        private IWebElement thirdWittAddTextField;


        [FindsBy(How=How.Id,Using = "submit")]
        private IWebElement submitButton;


        public IWebElement DateOfMarraigeTextField { get => dateOfMarraigeTextField; set => dateOfMarraigeTextField = value; }
        public IWebElement HusbandNameTextField { get => husbandNameTextField; set => husbandNameTextField = value; }
        public IWebElement HusbandReligionTextField { get => husbandReligionTextField; set => husbandReligionTextField = value; }
        public IWebElement HDobTextField { get => hDobTextField; set => hDobTextField = value; }
        public IWebElement HMarrStatus { get => hMarrStatus; set => hMarrStatus = value; }
        public IWebElement HAddTextField { get => hAddTextField; set => hAddTextField = value; }
        public IWebElement HZipCodeTextField { get => hZipCodeTextField; set => hZipCodeTextField = value; }
        public IWebElement HStateTextField { get => hStateTextField; set => hStateTextField = value; }
        public IWebElement HAadharTextField { get => hAadharTextField; set => hAadharTextField = value; }
        public IWebElement WNameTextField { get => wNameTextField; set => wNameTextField = value; }
        public IWebElement WReligionTextField { get => wReligionTextField; set => wReligionTextField = value; }
        public IWebElement WDobTextField { get => wDobTextField; set => wDobTextField = value; }
        public IWebElement WMarrStatus { get => wMarrStatus; set => wMarrStatus = value; }
        public IWebElement WAddTextField { get => wAddTextField; set => wAddTextField = value; }
        public IWebElement WZipCodeTextField { get => wZipCodeTextField; set => wZipCodeTextField = value; }
        public IWebElement WStateTextField { get => wStateTextField; set => wStateTextField = value; }
        public IWebElement WAadharTextField { get => wAadharTextField; set => wAadharTextField = value; }
        public IWebElement ThirdWittAddTextField { get => thirdWittAddTextField; set => thirdWittAddTextField = value; }
        public IWebElement ThirdWittNameTextField { get => thirdWittNameTextField; set => thirdWittNameTextField = value; }
        public IWebElement SecWittAddTextField { get => secWittAddTextField; set => secWittAddTextField = value; }
        public IWebElement SecondWittNameTextField { get => secondWittNameTextField; set => secondWittNameTextField = value; }
        public IWebElement FisrtWittAddTextField { get => fisrtWittAddTextField; set => fisrtWittAddTextField = value; }
        public IWebElement FirstWittNameTextField { get => firstWittNameTextField; set => firstWittNameTextField = value; }
        public IWebElement SubmitButton { get => submitButton; set => submitButton = value; }
        public IWebElement HImage { get => hImage; set => hImage = value; }
        public IWebElement WImage { get => wImage; set => wImage = value; }
    }
}
