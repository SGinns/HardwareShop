using System;
using System.Collections.Generic;

namespace HardwareClasses
{
    public class clssupplierCollection
    {
        private List<clsOrder> mOrderList = new List<clsOrder>();
        private clsOrder mThisOrder = new clsOrder();
        private int mCount;
        public List<clsOrder> orderList { get { return mOrderList; } set { mOrderList = value; } }
        public int Count { get { return mCount; } set { mCount = value; } }
        public clsOrder ThisOrder { get { return mThisOrder; } set { mThisOrder = value; } }

        public object ThisSupplier { get; set; }

        public clssupplierCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrder_SelectAll");

            PopulateArray(DB);
        }

        public int Add() 
        {
            clsDataConnection DB = new clsDataConnection();

            //DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.AddParameter("@Details", mThisOrder.Details);

            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete() 
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderId", mThisOrder.OrderId);

            DB.Execute("sproc_tblOrder_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@Details", mThisOrder.Details);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@Date", mThisOrder.Date);

            DB.Execute("sproc_tblOrder_Update");
        }

        public void ReportByDetails(string details) 
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@Details", details);

            DB.Execute("sproc_tblOrder_FilterByDetails");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB) 
        {
            Int32 index = 0;

            Int32 recordCount = 0;

            recordCount = DB.Count;

            mOrderList = new List<clsOrder>();

            while (index < recordCount)
            {
                clsOrder testItem = new clsOrder();

                testItem.CustomerId = Convert.ToInt32(DB.DataTable.Rows[index]["CustomerId"]);
                testItem.Date = Convert.ToDateTime(DB.DataTable.Rows[index]["DatePlaced"]);
                testItem.Details = Convert.ToString(DB.DataTable.Rows[index]["Details"]);
                testItem.OrderId = Convert.ToInt32(DB.DataTable.Rows[index]["OrderId"]);
                testItem.StaffId = Convert.ToInt32(DB.DataTable.Rows[index]["StaffId"]);

                mOrderList.Add(testItem);

                index++;
            }
        }
    }
}