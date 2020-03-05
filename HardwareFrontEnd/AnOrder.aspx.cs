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

        string orderId = txtBxOrderId.Text;
        string staffId = txtBxStaffId.Text;
        string customerId = txtBxCustomerId.Text;
        string date = txtBxDate.Text;
        string details = txtBxDetails.Text;

        string error = "";

        error = AnOrder.Validate(orderId, customerId, staffId, date, details);

        if (error == "")
        {
            AnOrder.OrderId = Convert.ToInt32(orderId);
            AnOrder.StaffId = Convert.ToInt32(staffId);
            AnOrder.CustomerId = Convert.ToInt32(customerId);
            AnOrder.Date = Convert.ToDateTime(date);
            AnOrder.Details = details;

            Session["AnOrder"] = AnOrder;

            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = error;
        };
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