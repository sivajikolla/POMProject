using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySatsuma.Helpers
{
    public class BrowserManager
    {
        public static IWebDriver driver;
               
        public static void openBrowser()
        {
            //This is the first error during framework creation

            string driverType = ConfigurationManager.AppSettings["driver"].ToLower();
            Console.WriteLine("Opening Chrome Browser." + driverType);

            switch (driverType)
            {
                case "chrome":
                    Console.WriteLine("Opening Chrome Browser.");
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;

                case "firefox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    break;

                case "ie":
                    var options = new InternetExplorerOptions
                    {
                        IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                        IgnoreZoomLevel = true,
                        EnableNativeEvents = false
                    };

                    driver = new InternetExplorerDriver(options);
                    driver.Manage().Window.Maximize();
                    break;

                case "edge":
                    driver = new EdgeDriver();
                    driver.Manage().Window.Maximize();
                    break;

                default:
                    Console.WriteLine($"No such browser: {driverType}");
                    throw new ArgumentException("Invalid browser name!");
            }
        }

        public static void quitBrowser()
        {
            driver.Quit();
        }

    }
}
