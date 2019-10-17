using Common.Poms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwordAutomation.Poms
{
    public class SwordBlogPom : BasePom
    {
        public SwordBlogPom(IWebDriver driver) : base(driver)
        {
        }

        public IList<IWebElement> GetBlogsList()
        {
            return Driver.FindElements(By.XPath("//div[@class='date' ]/li"));
        }
    }
}
