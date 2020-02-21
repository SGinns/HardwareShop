using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class AnOrderLine : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderLine orderLine = new clsOrderLine();

        orderLine = (clsOrderLine)Session["orderLine"];

        //Response.Write(orderLine.OrderLineId);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderLine orderLine = new clsOrderLine();

        orderLine.OrderLineId = Convert.ToInt32(txtBxOrderLineId.Text);
        orderLine.OrderId = Convert.ToInt32(txtBxOrderId.Text);
        orderLine.ProductId = Convert.ToInt32(txtBxProductId.Text);
        orderLine.Quantity = Convert.ToInt32(txtBxQuantity.Text);

        Session["orderLine"] = orderLine;

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