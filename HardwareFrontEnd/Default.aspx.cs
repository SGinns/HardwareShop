﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        AnOrder = (clsOrder)Session["AnAddress"];

        Response.Write(AnOrder.OrderId);
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        AnOrder.OrderId = Convert.ToInt32(txtBxOrderId);
        //AnOrder.StaffId = Convert.ToInt32();

        Session["AnOrder"] = AnOrder;

        Response.Redirect("OrderViewer.aspx");
    }
}