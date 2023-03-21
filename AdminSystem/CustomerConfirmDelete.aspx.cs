using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    // var to store the primary key value - scope
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //GET THE NUMBER OF THE CUSTOMER ID TO BE DELETED FROM THE SESSION OBJECT - check handout as quotations were missing for the session variable in []
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //Create a new instance of the customer class
        clsCustomerCollection Customer = new clsCustomerCollection();

        //find the record to delete
        Customer.ThisCustomer.Find(CustomerID);
        //delete the record
        Customer.Delete();
        //redirct to the list page
        Response.Redirect("CustomerList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirct to the list page
        Response.Redirect("CustomerList.aspx");
    }
}