using ICSharpCode.SharpZipLib.GZip;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Runtime.Intrinsics.X86;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Login1StepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"User opens the website")]
        public void GivenUserOpensTheWebsite()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [When(@"User enters ""([^""]*)"" , ""([^""]*)"" , ""([^""]*)"" , ""([^""]*)"" , ""([^""]*)""")]
        public void WhenUserEnters(string name, string email, string password, string gender, string dob)
        {
            Console.WriteLine($"Name: {name}\nEmail: {email}\nPassword: {password}\nGender: {gender}\nDob: {dob}");
            _driver.FindElement(By.XPath("//input[@name='name']")).SendKeys(name);
            _driver.FindElement(By.XPath("//input[@name='email']")).SendKeys(email);
            _driver.FindElement(By.XPath("//input[@id='exampleInputPassword1' and @type='password' and @placeholder='Password']")).SendKeys(password);
            _driver.FindElement(By.XPath("//select[@id='exampleFormControlSelect1']/option")).SendKeys(gender);
            _driver.FindElement(By.XPath("//input[@name='bday']")).SendKeys(dob);

      
        }

        [When(@"User clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            IWebElement login = _driver.FindElement(By.XPath("//input[@type='submit']"));

            login.Click();

            Thread.Sleep(6000);
        }

        [Then(@"User detail form is submited")]
        public void ThenUserDetailFormIsSubmited()
        {
            Console.WriteLine("Form is submitted");
        }
    }
}
