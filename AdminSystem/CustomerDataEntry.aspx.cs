using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the Property data 
        string CustomerID = txtCustomerID.Text;
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Address = txtAddress.Text;
        string PostCode = txtPostCode.Text;
        string DOB = txtDOB.Text;
        //variable to store the error messages to the user
        string Error = "";
        //validate the data
        Error = AnCustomer.Valid(FirstName, LastName, Address, PostCode, DOB);
        {
            if (Error == "")
            {
                //capture the FirstName
                AnCustomer.FirstName = FirstName;
                //capture LastName
                AnCustomer.LastName = LastName;
                //capture Address
                AnCustomer.Address = Address;
                //capture PostCode
                AnCustomer.PostCode = PostCode;
                //capture DOB
                AnCustomer.DOB = Convert.ToDateTime(DOB);
                //store address in the session object
                Session["AnCustomer"] = AnCustomer;
                //redirect to the viewer page
                Response.Write("CustomerViewer.aspx");
            }
            else
            {
                //display the error message to the user
                lblError.Text = Error;
            }
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the PK
        Int32 CustomerID;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the PK entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //find the record
        Found = AnCustomer.Find(CustomerID);
        //IF FOUND
        if (Found == true)
        {
            //display the values of the properties in the form
            txtFirstName.Text = AnCustomer.FirstName;
            txtLastName.Text = AnCustomer.LastName;
            txtAddress.Text = AnCustomer.Address;
            txtPostCode.Text = AnCustomer.PostCode;
            txtDOB.Text = AnCustomer.DOB.ToString();
            chkOver18.Checked = AnCustomer.Over18;

        }

    }
}