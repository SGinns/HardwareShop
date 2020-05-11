using HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteOrderLine : System.Web.UI.Page
{
    private Int32 OrderLineId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineId = Convert.ToInt32(Session["OrderLineId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection orderLines = new clsOrderLineCollection();
        if (orderLines.ThisOrderLine.find(OrderLineId) == true) 
        {
            orderLines.ThisOrderLine.find(OrderLineId);
        }

        orderLines.Delete();

        Response.Redirect("OrderLineList.aspx");
    }
}