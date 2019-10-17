using MathNet.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace sword_automation
{
    [TestClass]
    public class WebDriverTest
    {
        protected IWebDriver Driver { get; set; }
        [TestInitialize]
        public virtual Task Setup()
        {
            Driver.Url = "http://www.sword-activerisk.com/news-resources/blog/";
            Driver.Manage().Window.Maximize();
            return Task.CompletedTask;
        }

        [TestCleanup]
        public virtual async Task TearDown()
        {
            Driver.Quit();
        }
    }
}
