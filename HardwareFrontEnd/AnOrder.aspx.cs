using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class AnOrder : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {

        clsOrder AnOrder = new clsOrder();

        AnOrder = (clsOrder)Session["AnOrder"];

        OrderId = Convert.ToInt32(Session["OrderId"]);

        if (IsPostBack == false) 
        {
            if (OrderId != -1) 
            {
                DisplayOrders();
            }
        }

        //Response.Write(AnOrder.OrderId);
    }

    void DisplayOrders() 
    {
        clsOrderCollection orders = new clsOrderCollection();

        orders.ThisOrder.find(OrderId);

        txtBxOrderId.Text = orders.ThisOrder.OrderId.ToString();
        txtBxCustomerId.Text = orders.ThisOrder.CustomerId.ToString();
        txtBxStaffId.Text = orders.ThisOrder.StaffId.ToString();
        txtBxDetails.Text = orders.ThisOrder.Details;
        txtBxDate.Text = orders.ThisOrder.Date.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        string orderId = txtBxOrderId.Text;
        string staffId = txtBxStaffId.Text;
        string customerId = txtBxCustomerId.Text;
        string date = txtBxDate.Text;
        string details = txtBxDetails.Text;

        string error = AnOrder.Validate(orderId, customerId, staffId, date, details);

        clsOrderCollection orders = new clsOrderCollection();

        if (error == "")
        {
            AnOrder.OrderId = Convert.ToInt32(orderId);
            AnOrder.StaffId = Convert.ToInt32(staffId);
            AnOrder.CustomerId = Convert.ToInt32(customerId);
            AnOrder.Date = Convert.ToDateTime(date);
            AnOrder.Details = details;

            Session["AnOrder"] = AnOrder;

            clsOrderCollection orderList = new clsOrderCollection();
            if (!AnOrder.exists(AnOrder.OrderId))
            {
                orderList.ThisOrder = AnOrder;
                orderList.Add();
            }
            else 
            {
                orderList.ThisOrder = AnOrder;
                orderList.Update();
            }
        }
        else
        {
            lblError.Text = error;
        }

        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        Int32 orderId;

        Boolean found = false;

        try
        {
            orderId = Convert.ToInt32(txtBxOrderId.Text);
        }
        catch 
        {
            throw new Exception("Order Id was not specified");
        }

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