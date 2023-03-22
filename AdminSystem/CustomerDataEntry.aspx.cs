using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    //VARIABLE TO STORE THE PRIMARY KEY WITH THE PAGE LEVEL SCOPE
    //check the brackets
    Int32 CustomerID;


    protected void Page_Load(object sender, EventArgs e)
    {

        //get the number of the customer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]); //ADDED DOUBLE QUOTES TO THE SESSION CUSTOMERID IN [] THE SAME AS PAGE 25
        if (IsPostBack == false)
        {
            DisplayCustomer(); // CHECK IF THIS IS NEEDED HERE IN THE LAB HANDOUT AS IT IS ON LEIGHS SUBMISSION 

            //if this is not a new record
            if (CustomerID != -1)
            {
                //DISPLAY THE CURRENT DATA FOR THE RECORD
                DisplayCustomer();
            }
        }

    }

    void DisplayCustomer()
    {
        //create an instance of the customer
        clsCustomerCollection Customer = new clsCustomerCollection();

        //FIND THE RECORD TO UPDATE
        Customer.ThisCustomer.Find(CustomerID);

        //display the data for this record
        txtCustomerID.Text = Customer.ThisCustomer.CustomerID.ToString();
        txtFirstName.Text = Customer.ThisCustomer.FirstName;
        txtLastName.Text = Customer.ThisCustomer.LastName;
        txtAddress.Text = Customer.ThisCustomer.Address;
        txtPostCode.Text = Customer.ThisCustomer.PostCode;
        txtDOB.Text = Customer.ThisCustomer.DOB.ToString();
        chkOver18.Checked = Customer.ThisCustomer.Over18;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();

        //capture the Property data 
        //string CustomerID = txtCustomerID.Text;
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Address = txtAddress.Text;
        string PostCode = txtPostCode.Text;
        string DOB = txtDOB.Text;

        //variable to store the error messages to the user
        string Error = "";
      

        //validate the data
        Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
            if (Error == "")
            {
                //capture the customer ID
                //AnCustomer.CustomerID = Convert.ToInt32(CustomerID); 
                //CUSTOMER ID NOT NEEDED FOR ADD METHOD - ADDED TO THE CODE AFTER PAGE 9
                AnCustomer.CustomerID = CustomerID; //don't miss this bit !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!   //to STRING int32 ???
                //capture the FirstName
                AnCustomer.FirstName =FirstName;
                //capture LastName
                AnCustomer.LastName =LastName;
                //capture Address
                AnCustomer.Address =Address;
                //capture PostCode
                AnCustomer.PostCode =PostCode;
                //capture DOB
                AnCustomer.DOB =Convert.ToDateTime(DOB);
                //capture Over18
                AnCustomer.Over18 = chkOver18.Checked;

                //create a new instance of the the customer collection
                clsCustomerCollection CustomerList = new clsCustomerCollection();

                //set the ThisCustomer property - page 10 of creating the methods - NOT ON PAGE 19 WHEN IT IS UPDATED
                //CustomerList.ThisCustomer = AnCustomer;

                //if this is a new record i.e CustomerID = -1 then Add the data
                if (CustomerID== -1)
                {
                    //set the ThisCustomer property
                    CustomerList.ThisCustomer = AnCustomer;
                    //add the new record
                    CustomerList.Add();

                }
                    //OTHERWISE IT MUST BE An UPDATE

                else 
                {
                    // find the record to update
                    CustomerList.ThisCustomer.Find(Convert.ToInt32(CustomerID));
                    //set the ThisCustomer Property
                    CustomerList.ThisCustomer = AnCustomer;
                    //update the record
                    CustomerList.Update();
                }

                //redirect to the LIST page
                Response.Redirect("CustomerList.aspx");
            }
            
            else
            {
                //display the error message to the user
                lblError.Text = Error;
            }
        

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

        //create an instance of the class
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get primary key entered by user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = AnCustomer.Find(CustomerID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = AnCustomer.FirstName;
            txtLastName.Text = AnCustomer.LastName;
            txtAddress.Text = AnCustomer.Address;
            txtPostCode.Text = AnCustomer.PostCode;
            txtDOB.Text = AnCustomer.DOB.ToString();
            //chkOver18.Checked = AnCustomer.Over18.ToString(); //SORT OUT LATER

        }
        ////create an instance of the customer class
        //clsCustomer AnCustomer = new clsCustomer();
        ////capture the FirstName
        //string FirstName = txtFirstName.Text;
        ////capture the LastName
        //string LastName = txtLastName.Text;
        ////capture the Address
        //string Address = txtAddress.Text;
        ////capture the PostCode
        //string PostCode = txtPostCode.Text;
        ////capture the DOB
        //string DOB= txtDOB.Text;
        ////capture the Over18
        //string Over18 = txtLastName.Text;
        ////variable to store any errors
        //string Error = "";
        ////validate the data
        //Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
        //if (Error == "")
        //{
        //    //capture the firsname
        //    AnCustomer.FirstName = FirstName;
        //    //capture the last name
        //    AnCustomer.LastName = LastName;
        //    //capture the Address
        //    AnCustomer.Address = Address;
        //    //capture the PostCode
        //    AnCustomer.PostCode = PostCode;
        //    //capture the DOB
        //    AnCustomer.DOB = Convert.ToDateTime(DOB);
        //    //capture the Over18
        //    AnCustomer.Over18 = chkOver18.Checked;
        //    //create a new instance of the customer collection
        //    clsCustomerCollection CustomerList = new clsCustomerCollection();
        //    //set the ThisCustomer property
        //    CustomerList.ThisCustomer = AnCustomer;
        //    //add a new record
        //    CustomerList.Add();
        //    //redirect back to the listpage
        //    Response.Redirect("CustomerList.aspx");
        //}
        //else
        //{
        //    //display the error message
        //    lblError.Text = Error;
        //}

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}