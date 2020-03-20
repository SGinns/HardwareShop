using System;
using System.Web.UI;
using HardwareClasses;

public partial class OrderList : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false) 
        {
            DisplayOrders();
        }
    }

    void DisplayOrders() 
    {
        clsOrderCollection orders = new clsOrderCollection();

        lstOrderList.DataSource = orders.orderList;

        lstOrderList.DataValueField = "OrderId";

        lstOrderList.DataBind();
    }
}