using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        //INSTANCE OK TEST

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


        [TestMethod]

        public void FirstName_Property_OK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data
            string TestData = "Daniel";
            // Assign the data to the property
            AnCustomer.FirstName = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastName_Property_OK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data
            string TestData = "Davies";
            // Assign the data to the property
            AnCustomer.LastName = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.LastName, TestData);
        }

        [TestMethod]
        public void Address_Property_OK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Create some test data
            string TestData = "19 Michael Avenue";
            // Assign the data to the property
            AnCustomer.Address = TestData;
            // Test to see if the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]

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

        [TestMethod]

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

        //FIND METHOD OK TEST - Creating the Find Method

        [TestMethod]
        public void findMethodOK()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean Variable to store the results of the validation
            Boolean Found = false;
            // Create some test data to use with the method
            Int32 CustomerID = 3;
            // Invoke the method
            Found = AnCustomer.Find(CustomerID);
            // test to see if the result is true
            Assert.IsTrue(Found);
        }

        // PROPERTY DATA TESTS - Creating the Find Method

        [TestMethod]
        public void TestCustomerID_Found()
        {
            //Create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //Boolean Variable to store the results of the SEARCH
            Boolean Found = false;
            //Boolean Variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 CustomerID = 3;
            // Invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the customer ID
            
            if (AnCustomer.CustomerID != 3)
            { 
                OK = false;
            }
            // test to see if the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstName_Found()
        { 
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.FirstName != "Daniel")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastName_Found()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.LastName != "Davies")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddress_Found()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.Address != "19 Michael Avenue")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostCode_Found()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.PostCode != "LE1 9BH")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOB_Found()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.DOB != Convert.ToDateTime("01/03/2023"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestOver18_Found()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerID = 3;
            //invoke the method
            Found = AnCustomer.Find(CustomerID);
            //check the property
            if (AnCustomer.Over18 != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }
}
