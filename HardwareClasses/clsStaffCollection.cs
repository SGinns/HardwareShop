using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HardwareClasses
{
    public class clsStaffCollection
    {
        private clsStaff mthisStaff;
        private List<clsStaff> mStaffList;
        private int mCount;

        public clsStaff thisStaff
        {
            get
            {
                return mthisStaff;
            }
            set
            {
                mthisStaff = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                mCount = value;
            }
        }

        public List<clsStaff> StaffList
        {
            get
            {
                return this.mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public clsStaffCollection()
        {
            mStaffList = new List<clsStaff>();

            this.thisStaff = new clsStaff();

            Int32 Index = 0;

            Int32 RecordCount = 0;

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblStaff_SelectAll");

            RecordCount = DB.Count;

            while( Index < RecordCount)
            {
                clsStaff aStaff = new clsStaff();
                aStaff.active = Convert.ToBoolean(DB.DataTable.Rows[Index]["active"]);
                aStaff.EmployeeNo = Convert.ToInt32(DB.DataTable.Rows[Index]["employee_id"]);
                aStaff.salary = Convert.ToInt32(DB.DataTable.Rows[Index]["salary"]);
                aStaff.first_name = Convert.ToString(DB.DataTable.Rows[Index]["first_name"]);
                aStaff.last_name = Convert.ToString(DB.DataTable.Rows[Index]["last_name"]);

                mStaffList.Add(aStaff);

                Index++;

            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@salary", mthisStaff.salary);
            DB.AddParameter("@first_name", mthisStaff.first_name);
            DB.AddParameter("@last_name", mthisStaff.last_name);
            DB.AddParameter("@active", mthisStaff.active);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@EmployeeNo", mthisStaff.EmployeeNo);

            DB.Execute("sproc_tblStaff_Delete");
        }

        public void update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@employeeNo", mthisStaff.EmployeeNo);
            DB.AddParameter("@firstName", mthisStaff.first_name);
            DB.AddParameter("@lastName", mthisStaff.last_name);
            DB.AddParameter("@salary", mthisStaff.salary);
            DB.AddParameter("@active", mthisStaff.active);

            DB.Execute("sproc_tblStaff_Update");
        }
    }
}
