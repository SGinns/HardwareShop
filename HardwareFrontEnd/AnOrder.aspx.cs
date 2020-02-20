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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        Int32 orderId;

        Boolean found = false;

        orderId = Convert.ToInt32(txtBxOrderId.Text);

        found = AnOrder.find(2);

        if (found)
        {
            txtBxOrderId.Text = Convert.ToString(AnOrder.OrderId);
            txtBxCustomerId.Text = Convert.ToString(AnOrder.CustomerId);
            txtBxStaffId.Text = Convert.ToString(AnOrder.StaffId);
            txtBxDetails.Text = AnOrder.Details;
            txtBxDate.Text = Convert.ToString(AnOrder.Date);
        }
    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {

        clsOrder AnOrder = new clsOrder();

        Int32 orderId;

        Boolean found = false;

        orderId = Convert.ToInt32(txtBxOrderId.Text);

        found = AnOrder.find(2);

        if (found)
        {
            txtBxOrderId.Text = Convert.ToString(AnOrder.OrderId);
            txtBxCustomerId.Text = Convert.ToString(AnOrder.CustomerId);
            txtBxStaffId.Text = Convert.ToString(AnOrder.StaffId);
            txtBxDetails.Text = AnOrder.Details;
            txtBxDate.Text = Convert.ToString(AnOrder.Date);
        }
    }
}