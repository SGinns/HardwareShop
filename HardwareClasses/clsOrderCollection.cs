using System;
using System.Collections.Generic;

namespace HardwareClasses
{
    public class clsOrderCollection
    {
        private List<clsOrder> mOrderList = new List<clsOrder>();
        private int mCount;
        public List<clsOrder> orderList { get { return mOrderList; } set { mOrderList = value; } }
        public int Count { get { return mCount; } set { mCount = value; } }
        public clsOrder ThisOrder { get; set; }

        public clsOrderCollection()
        {
            Int32 index = 0;

            Int32 recordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrder_SelectAll");

            recordCount = DB.Count;

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