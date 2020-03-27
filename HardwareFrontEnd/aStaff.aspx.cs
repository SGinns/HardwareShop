using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class aStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();

        String firstname = TextBox2.Text;

        int salary = Convert.ToInt32(TextBox1.Text);
       
        String lastname = TextBox3.Text;

        Boolean active = Active.Checked;

        String Error = "";

        Error = staff.Valid(salary, firstname, lastname, active);

        if(Error == "")
        {
            staff.active = active;
            staff.first_name = firstname;
            staff.last_name = lastname;
            staff.salary = Convert.ToInt32(salary);
            Session["staff"] = staff;

            clsStaffCollection staffList = new clsStaffCollection();

            staffList.thisStaff = staff;

            staffList.Add();

            Response.Redirect("staffList.aspx");
        } else
        {
            lblError.Text = Error;
        }
    }

 
}