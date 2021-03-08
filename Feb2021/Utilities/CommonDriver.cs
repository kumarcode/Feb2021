using Feb2021.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Feb2021.Utilities
{
    class CommonDriver
    {
        // init and define webdriver 
        public IWebDriver driver;

        [OneTimeSetUp]
        public void Login()
        {
            // define chrome driver
            driver = new ChromeDriver(@"S:\Feb2021\Feb2021\");

            // login page obj and login steps
            LoginPage loginObj = new LoginPage();
            loginObj.LoginSteps(driver);

            // home page object and navigate step
            HomePage homeObj = new HomePage();
            homeObj.NavigateToTM(driver);
        }


        [OneTimeTearDown]
        public void FinalSteps()
        {
            driver.Quit();
        }
    }
}
