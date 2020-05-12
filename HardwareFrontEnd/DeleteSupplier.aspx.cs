using HardwareClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteSupplier : System.Web.UI.Page
{
    private Int32 SupplierId;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        clsSupplierCollection supplier = new clsSupplierCollection();

        supplier.thisSupplier.Equals(SupplierId);

        supplier.Delete();

        Response.Redirect("SupplierList.aspx");
    }
}