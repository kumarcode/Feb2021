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
    class EmployeeTests : CommonDriver
    {

       

        [Test]
        public void CreateEmployeeTest()
        {
            // Employee page object and create, edit, delete tests
            Employee empObj = new Employee();
            empObj.CreateEmployee(driver); // tc4


        }

        [Test]
        public void EditEmployeeTest()
        {
            // Employee page object and create, edit, delete tests
            Employee empObj = new Employee();
            empObj.EditEmployee(driver); // tc5
        }


        [Test]
        public void DeleteEmployeeTest()
        {
            // Employee page object and create, edit, delete tests
            Employee empObj = new Employee();
            empObj.DeleteEmployee(driver); // tc6
        }



    }
}
