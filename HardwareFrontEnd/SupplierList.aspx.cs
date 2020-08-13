using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class SupplierList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplaySupplier();
        }
    }

    void DisplaySupplier()
    {
       clsSupplierCollection supplier = new clsSupplierCollection();

        ListBox1.DataValueField = "SupplierId";

        ListBox1.DataTextField = "CompanyName";

        ListBox1.DataTextField = "Address";

        ListBox1.DataTextField = "PostalCode";

        ListBox1.DataTextField = "Phone";

        ListBox1.DataTextField = "StockAvaliablity";

        ListBox1.DataBind();
    }

   protected void btn_On_click_Add(object sender, EventArgs e)
    {
        Session["SupplierId"] = -1;

        Response.Redirect("addSupplier.aspx");
    }

    protected void btnDelete_onClick(object sender, EventArgs e)
    {
        Int32 SupplierId;

        if(ListBox1.SelectedIndex != -1)
        {
            SupplierId = Convert.ToInt32(ListBox1.SelectedValue);

            Session["SupplierId"] = SupplierId;

            Response.Redirect("DeleteSupplier.aspx");
        } else
        {
            lblError.Text = "Please Select a diffrent record";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierId;

        if(ListBox1.SelectedIndex != -1)
        {

            SupplierId = Convert.ToInt32(ListBox1.SelectedValue);

            Session["EmployeeNo"] = SupplierId;

            Response.Redirect("addSupplier.aspx");
        } else
        {
            lblError.Text = "Please select a record to edit";
        }
    }
    protected void btnApply_click(Object sender, EventArgs e)
    {
        clsSupplierCollection Supplier = new clsSupplierCollection();

        Supplier.ReportBySupplierId(filterBox.Text);

        ListBox1.DataTextField = "CompanyName";

        ListBox1.DataTextField = "Address";

        ListBox1.DataTextField = "PostalCode";

        ListBox1.DataTextField = "Phone";

        ListBox1.DataTextField = "StockAvaliablity";

        ListBox1.DataBind();
    }

    protected void btnClear_click(Object sender, EventArgs e)
    {
        clsSupplierCollection staff = new clsSupplierCollection();

        filterBox.Text = "";
        ListBox1.DataValueField = "SupplierId";

        ListBox1.DataTextField = "CompanyName";

        ListBox1.DataTextField = "Address";

        ListBox1.DataTextField = "PostalCode";

        ListBox1.DataTextField = "Phone";

        ListBox1.DataTextField = "StockAvaliablity";

        ListBox1.DataBind();

    }
}