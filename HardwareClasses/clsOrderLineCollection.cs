using System;
using System.Collections.Generic;

namespace HardwareClasses
{
    public class clsOrderLineCollection
    {
        private List<clsOrderLine> mOrderList = new List<clsOrderLine>();
        private int mCount;
        public List<clsOrderLine> orderLineList { get { return mOrderList; } set { mOrderList = value; } }
        public int Count { get { return mCount; } set { mCount = value; } }
        public clsOrderLine ThisOrderLine { get; set; }

        public clsOrderLineCollection()
        {
            Int32 index = 0;

            Int32 recordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblOrderLine_SelectAll");

            recordCount = DB.Count;

            while (index < recordCount) 
            {
                clsOrderLine testItem = new clsOrderLine
                {
                    OrderId = Convert.ToInt32(DB.DataTable.Rows[index]["OrderId"]),
                    OrderLineId = Convert.ToInt32(DB.DataTable.Rows[index]["OrderLineId"]),
                    Quantity = Convert.ToInt32(DB.DataTable.Rows[index]["Quantity"]),
                    ProductId = Convert.ToInt32(DB.DataTable.Rows[index]["ProductId"])
                };

                mOrderList.Add(testItem);

                index++;
            }
        }
    }
}