using HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderLineList : System.Web.UI.Page
{
    Int32 OrderLineId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderLineId = Convert.ToInt32(Session["OrderLineId"]);
        if (IsPostBack == false)
        {
            if(OrderLineId != -1)
            DisplayOrderLines();
        }
    }

    void DisplayOrderLines() 
    {
        clsOrderLineCollection orderLines = new clsOrderLineCollection();

        lstOrderLinesList.DataSource = orderLines.orderLineList;

        lstOrderLinesList.DataValueField = "OrderLineId";

        lstOrderLinesList.DataTextField = "OrderLineId";

        lstOrderLinesList.DataBind();
    }

    protected void AddBtn_Click(object sender, EventArgs e)
    {
        Session["OrderLineId"] = -1;
        Response.Redirect("OrderLineViewer.aspx");
    }

    protected void DeleteBtn_Click(object sender, EventArgs e)
    {
        Int32 OrderLineId;

        if (lstOrderLinesList.SelectedIndex != -1)
        {
            OrderLineId = Convert.ToInt32(lstOrderLinesList.SelectedValue);

            Session["OrderLineId"] = OrderLineId;

            Response.Redirect("DeleteOrderLine.aspx");
        }
        else
        {
            ErrorLbl.Text = "Please select a record to delete from the list";
        }
    }

    protected void EditBtn_Click(object sender, EventArgs e)
    {
        int OrderId;

        if (lstOrderLinesList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderLinesList.SelectedValue);
            Session["OrderLineId"] = OrderId;

            Response.Redirect("AnOrderLine.aspx");
        }
        else
        {
            ErrorLbl.Text = "Please select a record to edit from the list";
        }
    }
}