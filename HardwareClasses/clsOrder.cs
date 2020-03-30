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
                mDetails = Convert.ToString(db.DataTable.Rows[0]["Details"]);

                return true;
            }
            else
            {
                return false;
            }
        }
        public bool exists(int id)
        {
            clsDataConnection db = new clsDataConnection();

            db.AddParameter("@OrderId", id);

            db.Execute("sproc_tblOrder_FilterByOrderId");

            if (db.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Validate(string orderId, string customerId, string staffId, string date, string details)
        {
            string error = "";

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

            if (customerId.Length == 0)
            {
                error += "The customer id must not be blank : ";
            }

            if (customerId.Length > 6)
            {
                error += "The customer id must be less than 6 characters : ";
            }

            try
            {
                Convert.ToInt32(customerId);
            }
            catch
            {
                error += "The customer id is not a valid number : ";
            }

            if (staffId.Length == 0)
            {
                error += "The staff id must not be blank : ";
            }

            if (staffId.Length > 6)
            {
                error += "The staff id must be less than 6 characters : ";
            }

            try
            {
                Convert.ToInt32(staffId);
            }
            catch
            {
                error += "The staff id is not a valid number : ";
            }

            if (details.Length == 0)
            {
                error += "The details must not be blank : ";
            }

            if (details.Length > 100)
            {
                error += "The details must be no more than 100 characters : ";
            }

            try
            {
                DateTime dateTemp = Convert.ToDateTime(date);

                if (dateTemp < DateTime.Now.Date)
                {
                    error += "The date cannot be in the past : ";
                }

                if (dateTemp > DateTime.Now.Date)
                {
                    error += "The date cannot be in the future : ";
                }
            }
            catch
            {
                error += "The date was not a valid date : ";
            }
            return error;
        }
    }
}
