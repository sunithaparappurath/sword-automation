using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Poms
{
    public class BasePom
    {
        protected IWebDriver Driver { get; }

        public BasePom(IWebDriver driver)
        {
            Driver = driver;
            SeleniumExtras.PageObjects.PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(10)));
        }
    }
}
