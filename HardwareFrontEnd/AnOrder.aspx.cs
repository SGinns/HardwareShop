using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        AnOrder = (clsOrder)Session["AnAddress"];

        //Response.Write(AnOrder.OrderId);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        AnOrder.OrderId = Convert.ToInt32(txtBxOrderId.Text);
        AnOrder.StaffId = Convert.ToInt32(txtBxStaffId.Text);
        AnOrder.CustomerId = Convert.ToInt32(txtBxCustomerId.Text);
        AnOrder.Date = Convert.ToDateTime(txtBxDate.Text);
        AnOrder.Details = txtBxDetails.Text;

        Session["AnOrder"] = AnOrder;

        Response.Redirect("OrderViewer.aspx");
    }
}