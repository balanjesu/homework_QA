using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docler.POM.Pages
{
    public class FormPage
    {
        private readonly IWebDriver driver;

        public FormPage(IWebDriver Driver)
        {
            this.driver = Driver;
            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.Id, Using = "hello-input")]
        public IWebElement FormInputField { get; set; }

        [FindsBy(How = How.Id, Using = "hello-submit")]
        public IWebElement FormSubmitButton { get; set; }

        [FindsBy(How = How.Id, Using = "dh_logo")]
        public IWebElement DHLogo { get; set; }

        public HelloPage SubmitFormWithGivenValue(string valueToSubmitFormWith)
        {
            FormInputField.SendKeys(valueToSubmitFormWith);
            FormSubmitButton.Click();
            return new HelloPage(this.driver);
        }
    }
}
