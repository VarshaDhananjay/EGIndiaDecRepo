using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class TestOrangeHRMLoginFunctionalityStepDefinitions
    {

        private readonly ScenarioContext _scenarioContext;
        private IWebDriver _driver;

        public TestOrangeHRMLoginFunctionalityStepDefinitions(ScenarioContext scenarioContext)
        {

            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["WebDriver"] as IWebDriver;

        }



        [Given(@"User is on the login page")]

        public void GivenUserIsOnTheLoginPage()

        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());

            _driver = new FirefoxDriver();

            _driver.Manage().Window.Maximize();

            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            Thread.Sleep(6000);

        }
        

        [When(@"User enters the correct credentials")]

        public void WhenUserEntersTheCorrectCredentials()

        {

            IWebElement UserName = _driver.FindElement(By.XPath("//input[@placeholder='Username']"));

            UserName.SendKeys("Admin");

            Thread.Sleep(3000);

            IWebElement Password = _driver.FindElement(By.XPath("//input[@placeholder='Password']"));

            Password.SendKeys("admin123");

            Thread.Sleep(3000);

        }
        

        

        [When(@"User clicks on Login button")]

        public void WhenUserClicksOnLoginButton()

        {

            IWebElement Login = _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));

            Login.Click();

            Thread.Sleep(3000);

        }

        [Then(@"User is navigated to homepage")]

        public void ThenUserIsNavigatedToHomepage()

        {

            Console.WriteLine("Entered to home page");

        }
        [When(@"User enters the incorrect credentials")]
        public void WhenUserEntersTheIncorrectCredentials()
        {
            IWebElement UserName = _driver.FindElement(By.XPath("//input[@placeholder='Username']"));

            UserName.SendKeys("ssjjsj");

            Thread.Sleep(3000);

            IWebElement Password = _driver.FindElement(By.XPath("//input[@placeholder='Password']"));

            Password.SendKeys("vaahaha");

            Thread.Sleep(3000);
        }
        [Then(@"User is displayed with error message")]
        public void ThenUserIsDisplayedWithErrorMessage()
        {

            IWebElement error = _driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
            Console.WriteLine(error);
            Assert.That(error.Text, Is.EqualTo("Invalid credentials"));
            _driver.Close();
        }
        [When(@"User is navigated to homepage")]
        public void WhenUserIsNavigatedToHomepage()
        {
            Console.WriteLine("User is on homepage");
        }

        [Then(@"User selects the city and country information")]
        public void ThenUserSelectsTheCityAndCountryInformation(Table table)
        {
            foreach (var row in table.Rows)
            {
                string city = row["city"];
                string country = row["country"];

                Console.WriteLine(city + "  " + country);
            }

        }








    }
}
