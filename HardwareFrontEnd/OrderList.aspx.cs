using System;
using System.Web.UI;
using HardwareClasses;

public partial class OrderList : Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
                DisplayOrders();
        }
    }

    void DisplayOrders() 
    {
        clsOrderCollection orders = new clsOrderCollection();

        lstOrderList.DataSource = orders.orderList;

        lstOrderList.DataValueField = "OrderId";

        lstOrderList.DataTextField = "OrderId";

        lstOrderList.DataBind();
    }

    protected void AddBtn_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;

        Response.Redirect("AnOrder.aspx");
    }

    protected void DeleteBtn_Click(object sender, EventArgs e)
    {
        Int32 OrderId;

        if (lstOrderList.SelectedIndex != -1) 
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);

            Session["OrderId"] = OrderId;

            Response.Redirect("DeleteOrder.aspx");
        } 
        else
        {
            ErrorLbl.Text = "Please select a record to delete from the list";
        }
    }

    protected void EditBtn_Click(object sender, EventArgs e)
    {
        int OrderId;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;

            Response.Redirect("AnOrder.aspx");
        }
        else 
        {
            ErrorLbl.Text = "Please select a record to edit from the list";
        }
    }

    protected void ApplyBtn_Click(object sender, EventArgs e) 
    {
        clsOrderCollection orders = new clsOrderCollection();

        orders.ReportByDetails(txtBxDetails.Text);

        lstOrderList.DataSource = orders.orderList;

        lstOrderList.DataValueField = "OrderId";

        lstOrderList.DataTextField = "OrderId";

        lstOrderList.DataBind();
    }

    protected void ClearBtn_Click(object sender, EventArgs e)
    {
        clsOrderCollection orders = new clsOrderCollection();

        orders.ReportByDetails("");

        lstOrderList.DataSource = orders.orderList;

        lstOrderList.DataValueField = "OrderId";

        lstOrderList.DataTextField = "OrderId";

        lstOrderList.DataBind();
    }
}