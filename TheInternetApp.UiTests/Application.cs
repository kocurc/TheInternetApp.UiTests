using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TheInternetApp.UiTests
{
    internal class Application
    {
        public IWebDriver Driver { get; set; } 
        public ApplicationContext AppContext { get; set; }

        public Application()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            AppContext = new ApplicationContext();
        }

        public void CloseApplication()
        {
            Driver.Close();
            Driver.Dispose();
        }
    }
}
