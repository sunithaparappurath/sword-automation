using OpenQA.Selenium;
using SwordAutomation.Poms;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwordAutomation.Tasks
{
    public class SwordBlogTask
    {
        /// <summary>
        /// This method gets the list of all blogs and returns a list of the hyperlink to the blog and another list of count of blogs per month 
        /// </summary>
        /// <param name="blogPom"></param>
        /// <returns>List 1 of blog numbers and list 2 of URLs</returns>
        public (IList<string>, IList<string>) GetBlogItemsText(SwordBlogPom blogPom)
        {
            var itemsList = blogPom.GetBlogsList();
            int listCount = itemsList.Count;
            List<string> itemText = new List<string>(listCount);
            List<string> itemUrl = new List<string>(listCount);

            for (int i = 0; i < itemsList.Count; i++)
            {
                string newItem = itemsList[i].Text;
                string newUrl = itemsList[i].FindElement(By.TagName("a")).GetAttribute("href");
                itemText.Add(newItem);
                itemUrl.Add(newUrl);

            }

            return (itemText, itemUrl);
        }


    }
}
