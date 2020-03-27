using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class aStaff : System.Web.UI.Page
{
    int employeeNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        employeeNo = Convert.ToInt32(Session["EmployeeNo"]);
        if (!IsPostBack)
        {
            if (employeeNo != -1)
            {
                displayStaff();
            }
        }
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

            if (employeeNo == -1)
            {
                staffList.thisStaff = staff;

                staffList.Add();

            } else
            {

                staffList.thisStaff.find(employeeNo);

                staffList.thisStaff = staff;

                staffList.update();
            }



            Response.Redirect("staffList.aspx");
        } else
        {
            lblError.Text = Error;
        }
    }

    protected void displayStaff()
    {
        clsStaffCollection allstaff = new clsStaffCollection();

        allstaff.thisStaff.find(employeeNo);

        TextBox1.Text = allstaff.thisStaff.salary.ToString();
        TextBox2.Text = allstaff.thisStaff.first_name;
        TextBox3.Text = allstaff.thisStaff.last_name;

        Active.Checked = allstaff.thisStaff.active;
    }
}