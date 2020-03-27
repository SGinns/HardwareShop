using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HardwareClasses;

namespace HardwareTesting
{
    class clsStaffFactory
    {

        public clsStaff MakeNewStaffObj()
        {
            string[] firstnames = { "abby", "abigail", "adele", "adrian", "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian" };
            string[] lastNames = { "abbott", "acosta", "adams", "adkins", "aguilar" };

            Random rand = new Random(DateTime.Now.Second);
            string firstname = firstnames[rand.Next(0, firstnames.Length)];
            string lastname = lastNames[rand.Next(0, lastNames.Length)];
            int salary = rand.Next(1000, 100000);

            clsStaff obj = new clsStaff();

            obj.EmployeeNo = 1;
            obj.active = true;
            obj.first_name = firstname;
            obj.last_name = lastname;
            obj.salary = salary;

            return obj;
        }

    }
}
