using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class SupplierViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsSupplier supplier = new clsSupplier();

        supplier = (clsSupplier)Session["supplier"];

        Response.Write(supplier.SupplierId + " " + supplier.Company_name + " " + supplier.stock_avaliablity + " " + supplier.active);
    }
}