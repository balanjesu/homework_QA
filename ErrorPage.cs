using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docler.POM.Pages
{
    public class ErrorPage
    {
        private readonly IWebDriver driver;

        public ErrorPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(Driver, this);
        }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement DHLogo { get; set; }
    }
}
