using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    //VARIABLE TO STORE THE PRIMARY KEY WITH THE PAGE LEVEL SCOPE
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //create an isntance of the Customer Collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to the list of customers in the collection
        lstCustomerList.DataSource = Customers.CustomerList;
        //set the name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set the data field to display - in this case a concat of First and Last Names in Select Statement
       lstCustomerList.DataTextField = "LastName";
        //bind the data to the list
        lstCustomerList.DataBind();


    }

    protected void btnAddNewRecord_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect to the data entry page
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerID;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)  
        {
            //get the primary key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
                //store the data in the session object
                Session["CustomerID"] = CustomerID;
            //redirect to the edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }

        else
        {
            //if no record has been selected
            lblError.Text = "Please Select a record from the list to edit.";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the PK value of the record to be deleted
        Int32 CustomerID;

        //IF A RECORD HAS BEEN SELECTED FROM THE LIST
        if (lstCustomerList.SelectedIndex != -1)
        {
            //GET THE PK VALUE OF THE RECORD TO DELETE
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //REDIRECT TO THE DELETE PAGE
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else // if no record has been selected
        {
            lblError.Text = "Please select a record from the list to delete.";
        }

    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the customer collection
        clsCustomerCollection CustomerNames = new clsCustomerCollection();
        CustomerNames.FilterByLastName(txtFilter.Text);
        lstCustomerList.DataSource = CustomerNames.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "LastName";
        lstCustomerList.DataBind();
        //ADD A NEW ERROR MESSAGE HERE IF THE USER LEAVES THE TEXT BOX BLANK
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection CustomerNames = new clsCustomerCollection();
        CustomerNames.FilterByLastName("");
        txtFilter.Text = "";
        lstCustomerList.DataSource = CustomerNames.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "LastName";
        lstCustomerList.DataBind();
    }
}