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

            db.AddParameter("@OrderLineId", id);

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

        public string Validate(string orderLineId, string orderId, string productId, string quantity)
        {
            string error = "";

            if (orderLineId.Length == 0)
            {
                error += "The orderline id must not be blank : ";
            }

            if (orderLineId.Length > 6)
            {
                error += "The orderline id must be less than 6 characters : ";
            }

            try
            {
                Convert.ToInt32(orderLineId);
            }
            catch
            {
                error += "The orderline id is not a valid number : ";
            }

            if (orderId.Length == 0)
            {
                error += "The order id must not be blank : ";
            }

            if (orderId.Length > 6)
            {
                error += "The order id must be less than 6 characters : ";
            }

            try
            {
                Convert.ToInt32(orderId);
            }
            catch
            {
                error += "The order id is not a valid number : ";
            }

            if (productId.Length == 0)
            {
                error += "The product id must not be blank : ";
            }

            if (productId.Length > 6)
            {
                error += "The product id must be less than 6 characters : ";
            }

            try
            {
                Convert.ToInt32(productId);
            }
            catch
            {
                error += "The product id is not a valid number : ";
            }

            if (quantity.Length == 0)
            {
                error += "The quantity must not be blank : ";
            }

            try
            {
                if (Convert.ToInt32(quantity) == 0)
                {
                    error += "The quantity must be at least 1 : ";
                }
            }
            catch
            {
                error += "The quantity value is not valid : ";
            }

            try
            {
                Convert.ToInt32(quantity);
            }
            catch
            {
                error += "Quantity is not a valid number : ";
            }

            return error;
        }
    }
}
