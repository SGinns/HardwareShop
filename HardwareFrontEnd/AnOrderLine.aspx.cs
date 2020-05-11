using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class AnOrderLine : System.Web.UI.Page
{
    Int32 OrderLineId;
    protected void Page_Load(object sender, EventArgs e)
    {

        clsOrderLine AnOrderLine = new clsOrderLine();

        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];

        OrderLineId = Convert.ToInt32(Session["OrderLineId"]);

        if (IsPostBack == false)
        {
            if (OrderLineId != -1)
            {
                DisplayOrders();
            }
        }

        //Response.Write(AnOrderLine.OrderLineId);
    }

    void DisplayOrders() 
    {
        clsOrderLineCollection orderLines = new clsOrderLineCollection();

        orderLines.ThisOrderLine.find(OrderLineId);

        txtBxOrderLineId.Text = orderLines.ThisOrderLine.OrderLineId.ToString();
        txtBxOrderId.Text = orderLines.ThisOrderLine.OrderId.ToString();
        txtBxProductId.Text = orderLines.ThisOrderLine.ProductId.ToString();
        txtBxQuantity.Text = orderLines.ThisOrderLine.Quantity.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderLine orderLine = new clsOrderLine();

        string orderLineId = txtBxOrderLineId.Text;
        string orderId = txtBxOrderId.Text;
        string productId = txtBxProductId.Text;
        string quantity = txtBxQuantity.Text;

        string error = orderLine.Validate(orderLineId, orderId, productId, quantity);

        clsOrderLineCollection OrderLineList = new clsOrderLineCollection();

        if (error == "")
        {
            orderLine.OrderLineId = Convert.ToInt32(orderLineId);
            orderLine.OrderId = Convert.ToInt32(orderId);
            orderLine.ProductId = Convert.ToInt32(productId);
            orderLine.Quantity = Convert.ToInt32(quantity);

            Session["orderLine"] = orderLine;

            clsOrderLineCollection orders = new clsOrderLineCollection();
            clsOrderLine orderLineTemp = new clsOrderLine
            {
                OrderId = Convert.ToInt32(txtBxOrderId.Text),
                OrderLineId = Convert.ToInt32(txtBxOrderLineId.Text),
                ProductId = Convert.ToInt32(txtBxProductId.Text),
                Quantity = Convert.ToInt32(txtBxQuantity.Text),

            };

            if (!orderLineTemp.exists(orderLineTemp.OrderLineId))
            {
                orders.ThisOrderLine = orderLine;
                orders.Add();
            }
            else 
            {
                OrderLineList.ThisOrderLine = orderLine;
                OrderLineList.Update();
            }
        }
        else
        {
            lblError.Text = error;
        }

        Response.Redirect("OrderLineViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrderLine orderLine = new clsOrderLine();

        Int32 orderLineId;

        Boolean found = false;

        orderLineId = Convert.ToInt32(txtBxOrderLineId.Text);

        found = orderLine.find(orderLineId);

        if (found)
        {
            txtBxOrderLineId.Text = orderLine.OrderLineId.ToString();
            txtBxOrderId.Text = orderLine.OrderId.ToString();
            txtBxProductId.Text = orderLine.ProductId.ToString();
            txtBxQuantity.Text = orderLine.Quantity.ToString();
        }
    }
}