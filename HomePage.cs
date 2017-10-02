using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docler.POM.Pages
{
    public class HomePage
    {
        private readonly IWebDriver driver;

        public HomePage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div/div[1]/h1")]
        public IWebElement WelcomeMessage { get; set; }

        [FindsBy(How = How.ClassName, Using = "lead")]
        public IWebElement ExplanatoryText { get; set; }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement DHLogo { get; set; }
    }
}
