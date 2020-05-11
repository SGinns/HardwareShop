using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareClasses
{
    class clsSupplier
    {
        private int mSupplierId;
        private string mCompanyName;
        private string mAddress;
        private string mPostalCode;
        private string mPhone;
        private Boolean mStockAvaliablity;
        private DateTime mDate;

        public int SupplierId { get { return mSupplierId; } set { mSupplierId = value; } }
        public string CompanyName { get { return mCompanyName; } set { mCompanyName = value; } }
        public string Address { get { return mAddress; } set { mAddress = value; } }
        public string PostalCode { get { return mPostalCode; } set { mPostalCode = value; } }
        public string Phone { get { return mPhone; } set { mPhone = value; } }
        public Boolean StockAvaliablity { get { return mStockAvaliablity; } set { mStockAvaliablity = value; } }
        public DateTime Date { get { return mDate; } set { mDate = value; } }

        public bool find(int supplierid)
        {
            clssupplierConnection db = new clssupplierConnection();
            db.AddParameter("@SupplierId", supplierid);
            db.Execute("sproc_tblSupplier_FilterBySupplierId");
            if (db.Count == 1)
            {
                mSupplierId = Convert.ToInt32(db.DataTable.Rows[0]["SupplierId"]);
                mCompanyName = Convert.ToString(db.DataTable.Rows[0]["CompanyName"]);
                mAddress = Convert.ToString(db.DataTable.Rows[0]["Address"]);
                mPostalCode = Convert.ToString(db.DataTable.Rows[0]["PostalCode"]);
                mPhone = Convert.ToString(db.DataTable.Rows[0]["Phone"]);
                mStockAvaliablity = Convert.ToBoolean(db.DataTable.Rows[0]["StockAvaliablity"]);
                mDate = Convert.ToDateTime(db.DataTable.Rows[0]["Date"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}


