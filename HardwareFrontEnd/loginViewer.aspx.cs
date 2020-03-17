using HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class loginViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();
        Customer = (clsCustomer)Session["Customer"];
        Response.Write(Customer.UsernameId);
        Response.Write(Customer.CustomerId);
        Response.Write(Customer.emailaddress);
        Response.Write(Customer.address);
        Response.Write(Customer.dateofbirth);
        
    }
}