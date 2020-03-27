using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class DeleteAddress : System.Web.UI.Page
{
    int EmployeeNo;
    protected void Page_Load(object sender, EventArgs e)
    {
        EmployeeNo = Convert.ToInt32(Session["EmployeeNo"]);
    }

    protected void btnYes_onClick(object sender, EventArgs e)
    {
        clsStaffCollection staff = new clsStaffCollection();

        staff.thisStaff.find(EmployeeNo);

        staff.delete();

        Response.Redirect("AddressList.aspx");
    }

    protected void btnNo_onClick(object sender, EventArgs e)
    {
        Response.Redirect("AddressList.aspx");
    }
}