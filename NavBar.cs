using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docler.POM.Pages
{
    public class NavBar
    {
        private readonly IWebDriver driver;

        public NavBar(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "site")]
        public IWebElement UITestingNavBarPage { get; set; }

        [FindsBy(How = How.Id, Using = "home")]
        public IWebElement HomeNavBarPage { get; set; }

        [FindsBy(How = How.Id, Using = "form")]
        public IWebElement FormNavBarPage { get; set; }

        [FindsBy(How = How.Id, Using = "error")]
        public IWebElement ErrorNavBarPage { get; set; }

        [FindsBy(How = How.ClassName, Using = "active")]
        public IWebElement ActiveElement { get; set; }

        public HomePage NavigateToUITestingPage()
        {
            UITestingNavBarPage.Click();
            return new HomePage(this.driver);
        }

        public HomePage NavigateToHomePage()
        {
            HomeNavBarPage.Click();
            return new HomePage(this.driver);
        }

        public FormPage NavigateToFormPage()
        {
            FormNavBarPage.Click();
            return new FormPage(this.driver);
        }

        public ErrorPage NavigateToErrorPage()
        {
            ErrorNavBarPage.Click();
            return new ErrorPage(this.driver);
        }
    }
}
