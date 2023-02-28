using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Test to see it exists
            Assert.IsNotNull(AnCustomer);
        }

        //PROPERTY OK TESTS 

        [TestMethod]

        public void CustomerID_Property_OK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data
            Int32 TestData = 1;
            // Assign the data to the property
            AnCustomer.CustomerID = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.CustomerID, TestData);
        }

        public void FirstName_Property_OK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data
            string TestData = "Dawn";
            // Assign the data to the property
            AnCustomer.FirstName = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        public void LastName_Property_OK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data
            string TestData = "Jones";
            // Assign the data to the property
            AnCustomer.LastName = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        public void Address_Property_OK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data
            string TestData = "16 Acacia Avenue";
            // Assign the data to the property
            AnCustomer.Address = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        public void PostCode_Property_OK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data
            string TestData = "LE1 9BH";
            // Assign the data to the property
            AnCustomer.PostCode = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.PostCode, TestData);
        }

        public void DOB_Property_OK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            AnCustomer.DOB = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.DOB, TestData);
        }
        [TestMethod]
        public void Over18_Property_OK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data
            Boolean TestData = true;
            // Assign the data to the property
            AnCustomer.Over18 = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.Over18, TestData);
        }
    }
}
