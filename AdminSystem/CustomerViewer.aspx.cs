using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //get the data from the session object
        AnCustomer = (clsCustomer)Session["AnCustomer"];
        //display the PostCode for this entry
        Response.Write(AnCustomer.CustomerID); 
        Response.Write(AnCustomer.FirstName);
        Response.Write(AnCustomer.LastName);
        Response.Write(AnCustomer.Address);
        Response.Write(AnCustomer.PostCode);
        Response.Write(AnCustomer.DOB);
        Response.Write(AnCustomer.Over18);

    }
}