using System;

namespace ClassLibrary
{
    public class clsCustomer
    {

        //private data member for CustomerID property
        private Int32 mCustomerID;
        //private data member for FirstName property
        private string mFirstName;
        //private data member for LastName property
        private string mLastName;
        //private data member for Address property
        private string mAddress;
        //private data member for PostCode property
        private string mPostCode;
        //private data member for DOB property
        private DateTime mDOB;
        //private data member for Over18 property
        private Boolean mOver18;

        public Int32 CustomerID 
        {
            get 
            {
                //this code sends data out of the property
                return mCustomerID;

            }
            set 
            {
                //this code allowsd data into the property
                mCustomerID = value;
            }
        }
        public string FirstName
        {
            get
            {
                //this code sends data out of the property
                return mFirstName;

            }
            set
            {
                //this code allowsd data into the property
                mFirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                //this code sends data out of the property
                return mLastName;

            }
            set
            {
                //this code allowsd data into the property
                mLastName = value;
            }
        }
        public string Address
        {
            get
            {
                //this code sends data out of the property
                return mAddress;

            }
            set
            {
                //this code allowsd data into the property
                mAddress = value;
            }
        }
        public string PostCode
        {
            get
            {
                //this code sends data out of the property
                return mPostCode;

            }
            set
            {
                //this code allowsd data into the property
                mPostCode = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                //this code sends data out of the property
                return mDOB;

            }
            set
            {
                //this code allowsd data into the property
                mDOB = value;
            }
        }
        public bool Over18
        {
            get
            {
                //this code sends data out of the property
                return mOver18;

            }
            set
            {
                //this code allowsd data into the property
                mOver18 = value;
            }
        }


        public bool Find(int CustomerID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for thecustomer ID to search for
            DB.AddParameter("@CustomerID", CustomerID);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                //copy the data from the DB to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mOver18 = Convert.ToBoolean(DB.DataTable.Rows[0]["Over18"]);
                //return that everything worked ok
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem
                return false;
            }

        }
        
    
    
    }
}