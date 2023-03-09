using System;
using System.Collections.Generic;


namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private data member for thisCustomer
        clsCustomer mThisCustomer = new clsCustomer();


        public List<clsCustomer> CustomerList 
        {
            get 
            {
                // return the private data
                return mCustomerList;
            }
            set 
            {
                // set the private data
                mCustomerList = value;
            } 
        }
        public int Count 
        { 
            get
            {
                //return the count of the list
                return mCustomerList.Count;
            }
            set
            { 
            // we shall worry about this later
            }
        }




        public clsCustomer ThisCustomer
        {
            get
            {
                //return the private data
                return mThisCustomer;
            }

            set
            {
                //set the private data
                mThisCustomer = value;
            }
        }

        public int Add()
        {
            //adds a new record to the DB based on the values of the mThisCustomer
            //connect to the DB
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("FirstName", mThisCustomer.FirstName);
            DB.AddParameter("LastName", mThisCustomer.LastName);
            DB.AddParameter("Address", mThisCustomer.Address);
            DB.AddParameter("PostCode", mThisCustomer.PostCode);
            DB.AddParameter("DOB", mThisCustomer.DOB);
            DB.AddParameter("Over18", mThisCustomer.Over18);
            //exceute the stored procedure returning the PK
            return DB.Execute("sproc_tblCustomer_Insert");

        }




        //constructor for the class
        public clsCustomerCollection()
        {
            //variable for th eindex
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer AnCustomer = new clsCustomer();
                //read in the fields from the current record
                AnCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnCustomer.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AnCustomer.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AnCustomer.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnCustomer.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AnCustomer.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AnCustomer.Over18 = Convert.ToBoolean(DB.DataTable.Rows[Index]["Over18"]);
                //FullName is FirstName and LastName Concat in the SP - allows the first and last name to be displayed in the list box
                AnCustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FullName"]);
                //AnCustomer.FullName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName" + " " + "LastName"] );
                //add the record to the private data member
                mCustomerList.Add(AnCustomer);
                //point to the next record
                Index++;
            }

        }
    }
}