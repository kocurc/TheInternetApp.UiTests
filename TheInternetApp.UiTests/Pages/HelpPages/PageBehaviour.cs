using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TheInternetApp.UiTests.Pages.HelpPages
{
    public class PageBehaviour
    {
        private IWebDriver Driver { get; set; }

        public void Initialize(IWebDriver driver)
        {
            Driver = driver;
        }

        public void ScrollToTheBottom()
        {

        }
    }
}
