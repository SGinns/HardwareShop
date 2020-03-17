using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareClasses
{
    public class clsCustomer
    {
        private int mCustomerId;
        public int CustomerId { get { return mCustomerId; } set { mCustomerId = value; } }


        private string mUsernameId;
        public string UsernameId { get { return mUsernameId; } set { mUsernameId = value; } }


        private string mPassword;
        public string password { get { return mPassword; } set { mPassword = value; } }


        private string memailaddress;
        public string emailaddress { get { return memailaddress; } set { memailaddress = value; } }

        private string maddress;
        public string address { get { return maddress; } set { maddress = value; } }

        private string maemailverification;
        public string emailverification { get { return maemailverification; } set { maemailverification = value; } }

        private DateTime mdateofbirth;
        public DateTime dateofbirth { get { return mdateofbirth; } set { mdateofbirth = value; } }

        public Boolean find(int customerId)
        {
            return true;
        }

        public bool Find(int customerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", customerId);
            DB.Execute("sproc_tblStaff_FilterByCustomerId");
            if (DB.Count == 1)
            {

                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mUsernameId = Convert.ToString(DB.DataTable.Rows[0]["Username"]);
                memailaddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mdateofbirth = Convert.ToDateTime(DB.DataTable.Rows[0]["[D.O.B]"]);
                maddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);

                return true;
                               
            }
            
            else
            {
                return false;
            }
        }
    }
}
