using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V131.DOM;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace TestProject1_nunit.Framework.Framework_GenericUtility
{
    internal class WebDriverUtility
    {
        public void ToMaximize(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }
        public void ToMinimize(IWebDriver driver)
        {
            driver.Manage().Window.Minimize();
        }
        public void ImplicitwaitElements(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(IPathConstants.sec);
        }
        public void ExplicitwaitElementsClickable(IWebDriver driver, By element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(IPathConstants.sec));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
        public void ExplicitwaitElementsVisible(IWebDriver driver, By element )
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(IPathConstants.sec));
            wait.Until(ExpectedConditions.ElementIsVisible(element));
        }
        public void ToHandleDropdown(IWebElement element, string text)
        {
            SelectElement sel = new SelectElement(element);
            sel.SelectByText(text);
        }
        public void ToHandleDropdown(IWebElement element, int index)
        {
            SelectElement sel = new SelectElement(element);
            sel.SelectByIndex(index);
        }
        public void ToHandleDropdown(string value, IWebElement element)
        {
            SelectElement sel = new SelectElement(element);
            sel.SelectByValue(value);
        }
        public void ToHandleFrame(IWebElement element, IWebDriver driver)
        {
            driver.SwitchTo().Frame(element);
        }
        public void ToHandleFrame(string name, IWebDriver driver)
        {
            driver.SwitchTo().Frame(name);
        }
        public void ToHandleFrame(int index, IWebDriver driver)
        {
            driver.SwitchTo().Frame(index);
        }
        public void ToSwitchtoparentframe(IWebDriver driver)
        {
            driver.SwitchTo().ParentFrame();
        }
        public void ToMouseHover(IWebDriver driver, WebElement element)
        {
            Actions act = new Actions(driver);
            act.MoveToElement(element).Perform();
        }
        public void ToperformRightClick(IWebDriver driver, WebElement element)
        {
            Actions act = new Actions(driver);
            act.ContextClick(element).Perform();

        }
        public void ToperformClickandHold(IWebDriver driver, IWebElement element)
        {
            Actions act = new Actions(driver);
            act.ClickAndHold(element).Perform();
        }
        public void ToperformDragandDrop(IWebDriver driver, IWebElement source, IWebElement destination)
        {
            Actions act = new Actions(driver);
            act.DragAndDrop(source, destination).Perform();

        }
        public void ToperformDoubleClick(IWebElement element, IWebDriver driver)
        {
            Actions act = new Actions(driver);
            act.DoubleClick(element).Perform();

        }
        public void TohandlePopupandAccept(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }
        public void ToHandlePopupAnddismiss(IWebDriver driver)
        {
            IAlert dismisspop = driver.SwitchTo().Alert();
            dismisspop.Dismiss();
        }
        public string ToHandlePopupAndCaptureText(IWebDriver driver)
        {
            IAlert popup = driver.SwitchTo().Alert();
            // string? popuptext = popup.Text;
            return popup.Text;
           // popup.Accept();  
        }
        
        public void toSwitchWindow(IWebDriver driver)
        {
            System.Collections.ObjectModel.ReadOnlyCollection<string> allwinids = driver.WindowHandles;
            string currentwinid = driver.CurrentWindowHandle;
            foreach(var childwinid in allwinids)
            {
                if (currentwinid.Contains(childwinid))
                {
                    continue;
                }
                else
                {
                    driver.SwitchTo().Window(childwinid);
                }
            }
        }
        //public void ToSwitchWindow(IWebDriver driver, string partialtitle)
        //{
        //    System.Collections.ObjectModel.ReadOnlyCollection<string> allwinids = driver.WindowHandles;
        //    string currentwinid = driver.CurrentWindowHandle;
        //    foreach (var childid in allwinids)
        //    {
        //        string pagetitle = driver.SwitchTo().Window(childid).Title;
        //        if (pagetitle.Contains(partialtitle)) break;
        //    }
        //}
        public void ScrollusingJavaScriptExecutor(IWebDriver driver)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,500)");
        }
        public void ScrolltoViewUsingJavaScriptExecutor(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        public void Enterkeypress(IWebDriver driver)
        {
            Actions act = new Actions(driver);
            act.SendKeys(Keys.Enter).Perform();
        }
        public void TakeScreenShot(IWebDriver driver) 
        {
            C_Utility c=new C_Utility();
            string path = "C:\\Users\\HP\\Source\\Repos\\OnlineMarriageSystemNew\\OnlineMarriageSystem\\Report\\";
            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            screenshot.SaveAsFile(path +c.ForSystemDataandTime()+ ".png");
        }
    }
}
