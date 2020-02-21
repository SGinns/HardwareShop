using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrderLine orderLine = new clsOrderLine();

        orderLine = (clsOrderLine)Session["orderLine"];

        Response.Write(orderLine.OrderLineId);
    }
}