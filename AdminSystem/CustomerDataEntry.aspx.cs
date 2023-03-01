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
        //capture the Prpoerty data 
        AnCustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        AnCustomer.FirstName = txtFirstName.Text;
        AnCustomer.LastName = txtLastName.Text;
        AnCustomer.Address = txtAddress.Text;
        AnCustomer.PostCode = txtPostCode.Text;
        AnCustomer.DOB = Convert.ToDateTime(txtDOB.Text);
        //AnCustomer.Over18 = Convert.ToBoolean(chkOver18.Text);
        //store the address in the session object
        Session["AnCustomer"] = AnCustomer;
        // navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");
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