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

        //Customer details are correctly loaded
        [Test]
        public void CustomerMainMenuAssigned()
        {
            //Act
            String CustomerName = TestCustomerMainMenu.GetCustomerFullName();
            //Assert
            Assert.AreEqual("Tester Last", CustomerName, "Customer full name is obtainable.");
        }

        //Get string of initalised customer informations loaded in text box
        [Test]
        public void InitialiseStringFromTextBoxFirstName()
        {
            //Act
            String CustomerName = TestCustomerMainMenu.GetCustomerTextBoxInfomation();
            //Assert
            Assert.AreEqual("Tester Last", CustomerName, "Tester information is in Textbox");
        }

        [TearDown]
        public void TearDown()
        {
            Application.Exit();
        }
    }
}
