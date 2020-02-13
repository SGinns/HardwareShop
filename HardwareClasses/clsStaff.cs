using System;

namespace HardwareClasses
{
    public class clsStaff
    {
        private int mEmployeeNo;
        private int mSalary;
        private string mfirst_name;
        private string mlast_name;
        private bool mactive;
        private DateTime mcreated_at;

        public int EmployeeNo
        {
            get
            {
                return mEmployeeNo;
            }
            set
            {
                mEmployeeNo = value;
            }
        }

        public int salary {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }

        public string first_name 
        {
            get
            {
                return mfirst_name;
            }
            set
            {
                mfirst_name = value;
            }
        }

        public string last_name
        {
            get
            {
                return mlast_name;
            }
            set
            {
                mlast_name = value;
            }
        }

        public bool active
        {
            get
            {
                return mactive;
            }
            set
            {
                mactive = value;
            }
        }

        public DateTime created_at
        {
            get
            {
                return mcreated_at;
            }
            set
            {
                mcreated_at = value;
            }
        }



        public bool find(int employeeNo)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@EmployeeNo", employeeNo);

            DB.Execute("sproc_tblStaff_FilterByEmployeeNo");

            if (DB.Count == 1)
            {
                mEmployeeNo = Convert.ToInt32(DB.DataTable.Rows[0]["Employee_id"]);
                mSalary = Convert.ToInt32(DB.DataTable.Rows[0]["salary"]);
                mfirst_name = Convert.ToString(DB.DataTable.Rows[0]["first_name"]);
                mlast_name = Convert.ToString(DB.DataTable.Rows[0]["last_name"]);
                mactive = Convert.ToBoolean(DB.DataTable.Rows[0]["active"]);
                mcreated_at = Convert.ToDateTime(DB.DataTable.Rows[0]["created_at"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}