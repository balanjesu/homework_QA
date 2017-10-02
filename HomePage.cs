using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Support.PageObjects;

namespace DoclerHoldingAutomation.PageObjects
{
    class HomePage : DuodecaditsBasePage
    {
        
        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement Logo { get; set; }
        private PageUtils pageUtils = new PageUtils();

        public HomePage(IWebDriver driver) :base(driver)
        {
            PageFactory.InitElements(driver, this);
            
        }

        public String GetTitle()
        {
            return this.driver.Title;
        }

        public void WaitForPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("dh_logo")));
        }

        public bool IsCompanyLogoPresent()
        {
            return pageUtils.IsElementPresent(this.driver, By.Id(("dh_logo")));
        }

        public string GetHomePageContentText()
        {
            return this.driver.FindElement(By.CssSelector(".lead")).Text;
        }

        public string GetHomePageHeaderText()
        {
            return this.driver.FindElement(By.CssSelector(".ui-test h1")).Text;
        }

    }
}
