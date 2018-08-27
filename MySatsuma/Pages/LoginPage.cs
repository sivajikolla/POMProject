using MySatsuma.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenQA.Selenium.IWebElement;


namespace MySatsuma.Pages
{
    public class LoginPage

    {

        public LoginPage()
        {
            PageFactory.InitElements(BrowserManager.driver, this);

        }

        [FindsBy(How = How.Id, Using = "signin-loginid")]
        private IWebElement EMail;
        [FindsBy(How = How.Id, Using = "signin-password")]
        private IWebElement Password;
        [FindsBy(How = How.Id, Using = "submitButton")]
        private IWebElement SignIn;


        public void navigateToHomePage()
        {
            string url = ConfigurationManager.AppSettings["url"].ToLower();
            BrowserManager.driver.Navigate().GoToUrl(url);
        }

        public void enterValidLogInDetails()
        {
            EMail.SendKeys("sivaji.kolla@gmail.com");
            Password.SendKeys("kolla");
           SignIn.Click();  
        }
    }
}
