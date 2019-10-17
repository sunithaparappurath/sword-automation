using Common.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SwordAutomation.Poms;
using SwordAutomation.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SwordAutomation.Tests
{
    [TestClass]
    public class BlogTest :WebDriverTest
    {
        [TestMethod]
        public void CompareBlogNumbers()
        {
            var blogPom = new SwordBlogPom(Driver);
            var blogTask = new SwordBlogTask();
            var (blogNumbers, blogUrls) = blogTask.GetBlogItemsText(blogPom);

            for (int i = 0; i < blogNumbers.Count; i++)
            {
                string numberOfBlogs = blogNumbers[i].Split("(")[1];
                int index = numberOfBlogs.LastIndexOf(")");
                numberOfBlogs = numberOfBlogs.Substring(0, index);

                Driver.Url = blogUrls[i];
                var blogElement = Driver.FindElements(By.XPath("//*[@class='metaPost']"));
                int count = blogElement.Count();

                Assert.AreEqual(Convert.ToInt32(numberOfBlogs), count);
            }

        }

    }
}   
