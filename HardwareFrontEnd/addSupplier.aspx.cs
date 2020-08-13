using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HardwareClasses;

public partial class addSupplier : System.Web.UI.Page
{
    int SupplierId;

    public clsSupplier Supplier { get; private set; }
    public object Company_Name { get; private set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierId = Convert.ToInt32(Session["SupplierId"]);
        if (!IsPostBack)
        {
            if (SupplierId != -1)
            {
                displaySupplier();
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsSupplier supplier = new clsSupplier();

        String SupplierId = TextBox2.Text;

        String CompanyName = TextBox3.Text;

        String StockAvaliablity = TextBox1.Text;

        Boolean active = Active.Checked;

        String Error = "";

        Error = supplier.Valid(SupplierId, CompanyName, StockAvaliablity, active);

        if(Error == "")
        {
            supplier.active = active;
            supplier.SupplierId = SupplierId;
            supplier.Company_name = Company_Name;
            supplier.stock_avaliablity = StockAvaliablity;
            
            Session["supplier"] = supplier;

            clsSupplierCollection staffList = new clsSupplierCollection();

                        {
                            } 
            {

                  }



            Response.Redirect("SupplierList.aspx");
        } else
        {
            lblError.Text = Error;
        }
    }

    protected void displaySupplier()
    {
        clsSupplierCollection allSupplier = new clsSupplierCollection();

        allSupplier.thisSupplier.Equals(SupplierId);
    }
         
        public class SupplierList
    {
        public static clsSupplier thisSupplier { get; internal set; }

        internal static void Add()
        {
            throw new NotImplementedException();
        }

        internal static void update()
        {
            throw new NotImplementedException();
        }
    }
}