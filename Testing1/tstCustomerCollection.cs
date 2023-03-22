using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void Instance_OK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exists
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerList_OK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Dan";
            TestItem.LastName = "Dare";
            TestItem.Address = "Some Street";
            TestItem.PostCode = "LE1 9BH";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Over18 = true;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        //[TestMethod]
        //public void CountProperty_OK()
        //{
        //    //create an instance of the class we want to create
        //    clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //    //create some data to assign to the property
        //    Int32 SomeCount = 2;
        //    //assign the data to the property
        //    AllCustomers.Count = SomeCount;
        //    //test to see that the two values are the same
        //    Assert.AreEqual(AllCustomers.Count, SomeCount);
        //}

        [TestMethod]
        public void ThisCustomerProperty_OK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object
            TestCustomer.CustomerID = 1;
            TestCustomer.FirstName = "Dan";
            TestCustomer.LastName = "Dare";
            TestCustomer.Address = "Some Street";
            TestCustomer.PostCode = "LE1 9BH";
            TestCustomer.DOB = DateTime.Now.Date;
            TestCustomer.Over18 = true;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCount_OK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some data to assign to the property
            // in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Dan";
            TestItem.LastName = "Dare";
            TestItem.Address = "Some Street";
            TestItem.PostCode = "LE1 9BH";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Over18 = true;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethod_OK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data
            clsCustomer TestItem = new clsCustomer();

            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.CustomerID = 1;
            TestItem.FirstName = "Dan";
            TestItem.LastName = "Dare";
            TestItem.Address = "Some Street";
            TestItem.PostCode = "LE1 9BH";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Over18 = true;

            //set ThisCustomer to the TestData
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //SET THE PK of the test data
            TestItem.CustomerID = PrimaryKey;

            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethod_OK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data
            clsCustomer TestItem = new clsCustomer();

            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            //TestItem.CustomerID = 1; not included on page 11

            TestItem.FirstName = "Dan";
            TestItem.LastName = "Dare";
            TestItem.Address = "Some Street";
            TestItem.PostCode = "LE1 9BH";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Over18 = true;

            //set ThisCustomer to the test data page 11
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //set the PK of the test data
            TestItem.CustomerID = PrimaryKey;

            //MODIFY THE TEST DATA
            TestItem.FirstName = "Dawn";
            TestItem.LastName = "Deejay";
            TestItem.Address = "Another Street";
            TestItem.PostCode = "LE2 7TR";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Over18 = false;

            //SET THE RECORD BASED ON THE NEW TEST
            AllCustomers.ThisCustomer = TestItem;

            //update the record
            AllCustomers.Update();

            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }


        [TestMethod]
        public void DeleteMethod_OK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            //create the item of test data
            clsCustomer TestItem = new clsCustomer();

            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            //TestItem.CustomerID = 1; not included on page 11

            TestItem.CustomerID = 9; 
            TestItem.FirstName = "Dan";
            TestItem.LastName = "Dare";
            TestItem.Address = "Some Street";
            TestItem.PostCode = "LE1 9BH";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Over18 = true;

            //set ThisCustomer to the test data page 11
            AllCustomers.ThisCustomer = TestItem;

            //add the record
            PrimaryKey = AllCustomers.Add();

            //set the PK of the test data
            TestItem.CustomerID = PrimaryKey;

            //FIND THE RECORD
            AllCustomers.ThisCustomer.Find(PrimaryKey);



            //delete the record
            AllCustomers.Delete();

            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);

            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        //FILTER - report by Names Method OK

        [TestMethod]
        public void FilterByLastName_MethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create and intsance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string (should return all records)
            FilteredCustomers.FilterByLastName("");
            //Test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        //FILTER - report by LastName None Found

        [TestMethod]
        public void FilterByLastName_NoneFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a post code that doesn't exist
            FilteredCustomers.FilterByLastName("xxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void FilterByLastName_Test_Data_Found()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store the outcome
            Boolean OK = true;
            //apply a post code that doesn't exist
            FilteredCustomers.FilterByLastName("xxxxxxxx");
            //check that the correct number of records are found
            if (FilteredCustomers.Count ==2)
            {
                //check to see that the first record is ID 1
                if (FilteredCustomers.CustomerList[0].CustomerID != 1025)
                {
                    OK = false;
                }
                //check the first record is ID 3
                if (FilteredCustomers.CustomerList[1].CustomerID != 1026)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                //test the see that there are no new records
                Assert.IsTrue(OK);
            }
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }






    }
}



