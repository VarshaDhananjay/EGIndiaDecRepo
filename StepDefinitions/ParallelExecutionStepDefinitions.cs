using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using TechTalk.SpecFlow;
using WebDriverManager.DriverConfigs.Impl;
using NUnit.Framework;
[assembly: Parallelizable(ParallelScope.All)]
namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class ParallelExecutionStepDefinitions
    {
        private IWebDriver _driver;
        [Given(@"user is on the application page of chrome browser")]
        public void GivenUserIsOnTheApplicationPageOfChromeBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            // intialize the web driver 
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Given(@"user is on the application page of firefox browser")]
        public void GivenUserIsOnTheApplicationPageOfFirefoxBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Given(@"user is on the application page of edge browser")]
        public void GivenUserIsOnTheApplicationPageOfEdgeBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            _driver = new EdgeDriver();
            _driver.Navigate().GoToUrl("https://rahulshettyacademy.com/angularpractice/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }
    }
}
