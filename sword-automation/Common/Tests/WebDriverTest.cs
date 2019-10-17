using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace Common.Tests
{
    [TestClass]
    public class WebDriverTest
    {
        protected IWebDriver Driver { get; set; }
        [TestInitialize]
        public virtual void Setup()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Driver.Url = "http://www.sword-activerisk.com/news-resources/blog/";
            Driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
