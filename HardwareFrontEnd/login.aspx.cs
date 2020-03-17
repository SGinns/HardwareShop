using HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();
        Customer = (clsCustomer)Session["Customer"];
        Response.Write(Customer.CustomerId);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCustomer Customer = new clsCustomer();
        Int32 UsernameText;
        Boolean Found = false;
        UsernameText = Convert.ToInt32(txtUsernameId);




        Customer.UsernameId = UsernameText.Text;
        Customer.CustomerId = Convert.ToInt32(CustomerIDText.Text);
        Customer.emailaddress = EmailText.Text;
        Customer.address = AddressText.Text;
        Customer.dateofbirth = Convert.ToDateTime(DateOfBirthText.Text);

        Session["Customer"] = Customer;
        Response.Redirect("login.aspx");
    }
}