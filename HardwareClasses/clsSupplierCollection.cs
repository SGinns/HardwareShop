using System;
using System.Collections.Generic;

namespace HardwareClasses
{
    public class clsSupplierCollection
    {
        private const string V = "sproc_tblSupplier_Insert";
        private readonly List<clsSupplier> mSupplierList = new List<clsSupplier>();
        private clsSupplier mThisSupplier = new clsSupplier();
        private object mThisOrder;

        private List<clsSupplier> SupplierList { get => SupplierList; set { SupplierList = value; } }
        public int Count { get; set; }
        private clsSupplier Thisupplier { get { return mThisSupplier; } set { mThisSupplier = value; } }

        public clsSupplierCollection()
        {
            clssupplierConnection DB = new clssupplierConnection();

            DB.Execute("sproc_tbl_SelectAll");

            PopulateArray(DB);
        }

        public int Add()
        {
            clssupplierConnection DB = new clssupplierConnection();

            
            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@CompanyName", mThisSupplier.CompanyName);
            DB.AddParameter("@Address ", mThisSupplier.Address);
            DB.AddParameter("@PostalCode ", mThisSupplier.PostalCode);
            DB.AddParameter("@Phone", mThisSupplier.Phone);
            DB.AddParameter("@StockAvaliablity", mThisSupplier.StockAvaliablity);
            DB.AddParameter("@Date", mThisSupplier.Date);


            return DB.Execute(V);
        }

        public void Delete()
        {
            clssupplierConnection DB = new clssupplierConnection();

            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);

            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            clssupplierConnection DB = new clssupplierConnection();

            DB.AddParameter("@SupplierId", mThisSupplier.SupplierId);
            DB.AddParameter("@CompanyName", mThisSupplier.CompanyName);
            DB.AddParameter("@Address ", mThisSupplier.Address);
            DB.AddParameter("@PostalCode ", mThisSupplier.PostalCode);
            DB.AddParameter("@Phone", mThisSupplier.Phone);
            DB.AddParameter("@StockAvaliablity", mThisSupplier.StockAvaliablity);
            DB.AddParameter("@Date", mThisSupplier.Date);

            DB.Execute("sproc_tblSupplier_Update");
        }

        public void ReportByDetails(string details)
        {
            clssupplierConnection DB = new clssupplierConnection();

            DB.AddParameter("@Details", details);

            DB.Execute("sproc_tblSupplier_FilterByDetails");

            PopulateArray(DB);
        }

        void PopulateArray(clssupplierConnection DB)
        {
            if (DB == null)
            {
                throw new ArgumentNullException(nameof(DB));
            }

            Int32 index = 0;

            Int32 recordCount = 0;

            recordCount = DB.Count;
            List<clsSupplier> mSupplierList = new List<clsSupplier>();
            while (index < recordCount)
            {
                clsSupplier testItem = new clsSupplier();

                testItem.SupplierId = Convert.ToInt32(DB.DataTable.Rows[index]["SupplierId"]);
                testItem.CompanyName = Convert.ToString(DB.DataTable.Rows[index]["CompanyName"]);
                testItem.Address = Convert.ToString(DB.DataTable.Rows[index]["Address"]);
                testItem.PostalCode = Convert.ToString(DB.DataTable.Rows[index]["PostalCode"]);
                testItem.Phone = Convert.ToString(DB.DataTable.Rows[index]["Phone"]);
                testItem.Phone = Convert.ToString(DB.DataTable.Rows[index]["Phone"]);
                testItem.Date = Convert.ToDateTime(DB.DataTable.Rows[index]["DatePlaced"]);
               
                               SupplierList.Add(testItem);

                index++;
            }
        }
    }
}