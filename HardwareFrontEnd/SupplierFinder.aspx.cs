using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class SupplierFinder : System.Web.UI.Page
{
    private readonly object Date;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void FindBtn_On_click(object sender, EventArgs e)
    {
        clssupplierConnection Supplier = new clsSupplier();

        Boolean Found = false;
        int SupplierId = Convert.ToInt32(SupplierIdBox.Text);
        Found = Supplier.find(SupplierId);

        if (Found)
        {
            CompanyNameBox.Text = Supplier.Company_name;
            AddressBox.Text = Supplier.Address;
            PostalCode.Text = Supplier.Postalcode;
            Phone.Text = Supplier.phone;
            StockAvaliablity.Text = Supplier.stock_avaliablity;
                    }
    }
}

public class AddressBox
{
    internal static object Text;
}

public class CompanyNameBox
{
    internal static object Text;
}