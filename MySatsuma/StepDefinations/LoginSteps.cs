using MySatsuma.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MySatsuma.StepDefinations
{
    [Binding]
    public class LoginSteps
    {

        private LoginPage loginPage = new LoginPage();


        [Given(@"I navigate to the homepage")]
        public void GivenINavigateToTheHomepage()
        {
            loginPage.navigateToHomePage();
            loginPage.enterValidLogInDetails();
        }

        [Given(@"I login to the application")]
        public void GivenILoginToTheApplication()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }

}
