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

        public string Valid(string firstName, string lastName, string address, string postCode, string dOB)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store date values
            DateTime DateTemp;

            //if the first name  is blank
            if (firstName.Length == 0)
            {
                //record the error
                Error = Error + "The First Name cannot be blank : ";
            }

            //if the first name is greater than 20 characters
            if (firstName.Length > 20)
            {
                //record the error
                Error = Error + "The first name must be less than 20 characters : ";
            }

            //if the last name  is blank
            if (lastName.Length == 0)
            {
                //record the error
                Error = Error + "The Last Name cannot be blank : ";
            }

            //if the last name is greater than 20 characters
            if (lastName.Length > 20)
            {
                //record the error
                Error = Error + "The last name must be less than 20 characters : ";
            }

            //if the address  is blank
            if (address.Length == 0)
            {
                //record the error
                Error = Error + "The address cannot be blank : ";
            }

            //if the address is greater than 50 characters
            if (address.Length > 50)
            {
                //record the error
                Error = Error + "The address must be less than 50 characters : ";
            }

            try
            {
                //copy the dOB value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dOB);
                //check to see if the date is equal to YESTERDAY's date
                if (DateTemp == DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date of birth cannot be today's date : ";
                }

                //check to see if the date is greater than YESTERDAY's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date of birth cannot be in the future : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date of birth is  not a valid date : ";
            }


            //is the post code blank
            if (postCode.Length == 0)
            {
                //record the error
                Error = Error + "The post code may not be blank : ";
            }
            //if the post code is too long
            if (postCode.Length > 12)
            {
                //record the error
                Error = Error + "The post code must be less than 12 characters : ";
            }

            //return any error messages
            return Error;

        }
    }
}