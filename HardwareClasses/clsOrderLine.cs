using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareClasses
{
    public class clsOrderLine
    {
        private Int32 mOrderLineId;
        private Int32 mOrderId;
        private Int32 mProductId;
        private Int32 mQuantity;

        public int OrderLineId { get { return mOrderLineId; } set { mOrderLineId = value; } }
        public int OrderId { get { return mOrderId; } set { mOrderId = value;} }
        public int ProductId { get { return mProductId; } set {mProductId = value; } }
        public int Quantity { get { return mQuantity; } set { mQuantity = value; } }

        public bool find(int id)
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter(id, "@OrderLineId");

            db.Execute("sproc_tblOrder_FilterByOrderLineId");

            if (db.Count == 1)
            {
                mOrderLineId = Convert.ToInt32(db.DataTable.Rows[0]["OrderLineId"]);
                mOrderId = Convert.ToInt32(db.DataTable.Rows[0]["OrderId"]);
                mProductId = Convert.ToInt32(db.DataTable.Rows[0]["ProductId"]);
                mQuantity = Convert.ToInt32(db.DataTable.Rows[0]["Quantity"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
