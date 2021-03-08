using Feb2021.Pages;
using Feb2021.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Feb2021
{
    [TestFixture]
    [Parallelizable]
    class Program : CommonDriver
    {
        //// Employee page object and create, edit, delete tests
        //Employee empObj = new Employee();
        //empObj.CreateEmployee(driver); // tc4
        //    empObj.EditEmployee(driver); // tc5
        //    empObj.DeleteEmployee(driver); // tc6



        [Test]
        public void CreateTMTest()
        {
            // TM page object and create step
            TMPage tmObj = new TMPage();
            tmObj.CreateTM(driver); // tc1
        }

        [Test]
        public void EditTMTest()
        {
            // TM page object and edit step
            TMPage tmObj = new TMPage();
            tmObj.EditTM(driver); // tc2
        }


        [Test]
        public void DeleteTMTest()
        {
            // TM page object and delete step
            TMPage tmObj = new TMPage();
            tmObj.DeleteTM(driver);// tc3
        }



    }
}
