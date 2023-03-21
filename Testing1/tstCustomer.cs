using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string FirstName = "Dawn";
        string LastName = "Joone";
        string Address = "16 Maidstone Road";
        string PostCode = "LE1 1AS";
        string DOB = DateTime.Now.Date.AddDays(-1).ToString(); // SHOULD STORE YESTERDAY'S DATE
        //string DOB = DateTime.Now.Date.ToString();


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
        //TEST DATA BASED ON RECORD 3 IN LOCAL DB ON ONEDRIVE

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
            if (AnCustomer.FirstName != "Dee")
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
            if (AnCustomer.LastName != "JayTest")
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

        //Valid Method OK Test - Adding Validation (Middle Layer) handout

        [TestMethod]
        public void ValidMethod_OK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see if the result is correct
            Assert.AreEqual(Error, "");
         
        }

        // TESTS FOR PARAMETERS

        //********************************* FIRST NAME PARAMETER TESTS **************************************************************************

        [TestMethod]
        public void FirstName_MinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string FirstName = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void FirstName_Min()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void FirstName_MinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        

        [TestMethod]
        public void FirstName_Mid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(10, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void FirstName_MaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(19, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstName_Max()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string FirstName = "";
            FirstName = FirstName.PadRight(20, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstName_MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string FirstName = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }




        //**************************** LAST NAME PARAMETER TESTS **************************************************************************

        [TestMethod]
        public void LastName_MinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string LastName = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastName_Min()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void LastName_MinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void LastName_Mid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(10, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastName_MaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(19, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastName_Max()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string LastName = "";
            LastName = LastName.PadRight(20, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastName_MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string LastName = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //************************************* ADDRESS PARAMETER TESTS **************************************************************************

        [TestMethod]
        public void Address_MinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Address = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Address_Min()
        {
            
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void Address_MinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void Address_Mid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(25, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address_MaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(49, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address_Max()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "";
            Address = Address.PadRight(50, 'a');
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void Address_MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Address = "";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //************************** POSTCODE PARAMETER TESTS **************************************************************************

        [TestMethod]
        public void PostCode_MinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = ""; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PostCode_Min()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "a";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCode_MinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string PostCode = "aa"; //this should trigger an error
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostCode_Mid()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void PostCode_MaxLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Address = "aaaaaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCode_Max()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "";
            PostCode = "aaaaaaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostCode_MaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string PostCode = "aaaaaaaaaaaaa";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        //**************************************************************************DOB DATE OF BIRTH PARAMETER TESTS **************************************************************************


        //[TestMethod]
        //public void DOB_ExtremeMin()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomer AnCustomer = new clsCustomer();
        //    //string variable to store any error message
        //    String Error = "";
        //    //create a variable to store the test date data
        //    DateTime TestDate;
        //    //set the date to YESTERDAY's date
        //    TestDate = DateTime.Now.Date.AddDays(-1);
        //    //change the date to whatever the date is LESS 150 years
        //    TestDate = TestDate.AddYears(-150);
        //    //convert the date variable to a string variable
        //    string DOB = TestDate.ToString();
        //    //invoke the method
        //    Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
        //    //test to see that the result is correct
        //    Assert.AreNotEqual(Error, "");
        //}



        [TestMethod]
        // tests to see if the date of birth is equal to yesterday's date - a dob cannot be today's date - should pass if equal
        
        public void DOB_Min()
        {
            //WORKING OK 
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to YESTERDAY's date (Boundary)
            TestDate = DateTime.Now.Date.AddDays(-1);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DOB_MinPlusOne()
        {
            //WORKING OK 
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to YESTERDAY's date
            TestDate = DateTime.Now.Date.AddDays(-1);
            //change the date to TODAYS's date
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DOB_ExtremeMax()
        {
            //string DOB = DateTime.Now.Date.AddDays(-1).ToString(); // GOOD TEST DATA - SHOULD STORE YESTERDAY'S DATE

            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to YESTERDAY's date
            TestDate = DateTime.Now.Date.AddDays(-1);
            //change the date to whatever the date is PLUS 150 years
            TestDate = TestDate.AddYears(+150);
            //convert the date variable to a string variable
            string DOB = TestDate.ToString();
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        //**************************************************************************INVALID DATA - PARAMETER TESTS **************************************************************************


        [TestMethod]
        public void DOB_InvalidData()
        {
          
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //set the DOB to a non date value
           string DOB = "This is not a date!";
            //invoke the method
            Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
