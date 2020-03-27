using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
       clsStaffCollection staff = new clsStaffCollection();

        ListBox1.DataSource = staff.StaffList;

        ListBox1.DataValueField = "EmployeeNo";

        ListBox1.DataTextField = "first_name";

        ListBox1.DataBind();
    }

    protected void btn_On_click_Add(object sender, EventArgs e)
    {
        Session["employee_id"] = -1;

        Response.Redirect("aStaff.aspx");
    }

    protected void btnDelete_onClick(object sender, EventArgs e)
    {
        Int32 EmployeeNo;

        if(ListBox1.SelectedIndex != -1)
        {
            EmployeeNo = Convert.ToInt32(ListBox1.SelectedValue);

            Session["EmployeeNo"] = EmployeeNo;

            Response.Redirect("DeleteAddress.aspx");
        } else
        {
            lblError.Text = "Please Select a record";
        }
    }
}