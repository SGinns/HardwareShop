using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareClasses
{
    public class clsOrder
    {
        private Int32 mOrderId;
        private Int32 mCustomerId;
        private Int32 mStaffId;
        private DateTime mDate;
        private string mDetails;
        public int OrderId { get { return mOrderId; } set { mOrderId = value;} }
        public int CustomerId { get { return mCustomerId; } set {mCustomerId = value; } }
        public int StaffId { get {return mStaffId; } set {mStaffId = value; } }
        public DateTime Date { get { return mDate; } set { mDate = value; } }
        public string Details { get {return mDetails; } set {mDetails = value; } }

        public bool find(int id)
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@OrderId", id);

            db.Execute("sproc_tblOrder_FilterByOrderId");

            if (db.Count == 1)
            {
                mOrderId = Convert.ToInt32(db.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(db.DataTable.Rows[0]["CustomerId"]);
                mStaffId = Convert.ToInt32(db.DataTable.Rows[0]["StaffId"]);
                mDate = Convert.ToDateTime(db.DataTable.Rows[0]["DatePlaced"]);
                mDetails = Convert.ToString(db.DataTable.Rows[0]["Details"]); ;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
