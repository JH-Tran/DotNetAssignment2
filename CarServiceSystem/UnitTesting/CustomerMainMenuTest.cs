using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarServiceSystem.Forms;
using NUnit.Framework;

namespace CarServiceSystem.UnitTesting
{
    public class CustomerMainMenuTest
    {
        private Customer TestCusomter;
        private CustomerMainMenu TestCustomerMainMenu;

        [SetUp]
        public void SetUp()
        {
            //Arange
            TestCusomter = new Customer("Tester", "Last", "test@gmail.com", "abc");
            TestCustomerMainMenu = new CustomerMainMenu(TestCusomter);
        }

        [Test]
        public void CustomerMainMenuAssigned()
        {
            //Act
            String CustomerName = TestCustomerMainMenu.PrintCustomerFullName();
            //Assert
            Assert.AreEqual("Tester Last", CustomerName, "Customer full name is obtainable.");
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
