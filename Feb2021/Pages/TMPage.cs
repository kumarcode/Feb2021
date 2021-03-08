using Feb2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Feb2021.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Create new Time and Material test

            // click create new button 
            driver.FindElement(By.XPath("//*[@id='container']/p/a")).Click();
            Wait.ElementPresent(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span");

            // select time from drop down list 
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span")).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]")).Click();
            Thread.Sleep(500);


            // enter code
            driver.FindElement(By.Id("Code")).SendKeys("Feb2021");

            // enter description 
            driver.FindElement(By.Id("Description")).SendKeys("Feb2021-Description");

            // enter price
            driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
            driver.FindElement(By.Id("Price")).SendKeys("123");

            // upload attachement - TBC --todo

            // click save 
            driver.FindElement(By.Id("SaveButton")).Click();
            Thread.Sleep(1500);

            // go to last page 
            driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]")).Click();
            Thread.Sleep(1500);

            // option - 1
            Assert.That(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text == "Feb2021");

            // option - 2
            Assert.That(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text, Is.EqualTo("Feb2021"));


            // options - 3
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text != "Feb2021")
            {
                Assert.Pass("Time record created successfully, Test Passed");
            }
            else
            {
                Assert.Fail("Test failed, time record creation failed");
            }
        }

        public void EditTM(IWebDriver driver)
        {
            // Edit Time and Material test --Todo

        }

        public void DeleteTM(IWebDriver driver)
        {
            // Delete Time and Material test --Todo

        }
    }
}
