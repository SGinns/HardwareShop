using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class staffFinder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void FindBtn_On_click(object sender, EventArgs e)
    {
        clsStaff staff = new clsStaff();

        Int32 EmployeeID;

        Boolean Found = false;

        EmployeeID = Convert.ToInt32(EmployeeIDBox.Text);

        Found = staff.find(EmployeeID);

        if (Found)
        {
            FirstNameBox.Text = staff.first_name;
            LastNameBox.Text = staff.last_name;
            SalaryBox.Text = Convert.ToString(staff.salary);
            DateAddedBox.Text = Convert.ToString(staff.created_at);


        }
    }
}