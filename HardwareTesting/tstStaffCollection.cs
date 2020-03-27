using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HardwareTesting
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();
            Assert.IsNotNull(allStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();

            List<clsStaff> tstList = new List<clsStaff>();

            clsStaff tstItem = new clsStaff();

            tstItem.EmployeeNo = 1;
            tstItem.salary = 10000;
            tstItem.first_name = "Jeff";
            tstItem.last_name = "Jeffy";
            tstItem.active = true;

            tstList.Add(tstItem);

            allStaff.StaffList = tstList;

            Assert.AreEqual(allStaff.StaffList, tstList);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();

            List<clsStaff> tstList = new List<clsStaff>();

            clsStaff tstStaff = new clsStaffFactory().MakeNewStaffObj();

            tstList.Add(tstStaff);

            allStaff.StaffList = tstList;

            Assert.AreEqual(allStaff.Count, tstList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();

            clsStaff test = new clsStaffFactory().MakeNewStaffObj();

            Int32 primaryKey = 0;

            allStaff.thisStaff = test;

            primaryKey = allStaff.Add();

            test.EmployeeNo = primaryKey;

            allStaff.thisStaff.find(primaryKey);

            Assert.AreEqual(allStaff.thisStaff, test);


        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();

            clsStaff test = new clsStaff();

            int primaryKey = 0;

            test.active = true;
            test.EmployeeNo = 10;
            test.first_name = "Joe";
            test.last_name = "Bloggs";
            test.salary = 15000;

            allStaff.thisStaff = test;

            primaryKey = allStaff.Add();

            test.EmployeeNo = primaryKey;

            allStaff.thisStaff.find(primaryKey);

            allStaff.delete();

            Boolean Found = allStaff.thisStaff.find(primaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMehtodOK()
        {
            clsStaffCollection allStaff = new clsStaffCollection();

            clsStaff staff = new clsStaff();

            Int32 PrimaryKey = 0;

            staff.active = true;
            staff.first_name = "Test";
            staff.last_name = "Test";
            staff.salary = 15000;

            allStaff.thisStaff = staff;

            PrimaryKey = allStaff.Add();

            staff.EmployeeNo = PrimaryKey;

            staff.active = false;
            staff.first_name = "test2";
            staff.last_name = "test2";
            staff.salary = 100000;

            allStaff.thisStaff = staff;

            allStaff.update();

            allStaff.thisStaff.find(PrimaryKey);

            Assert.AreEqual(allStaff.thisStaff, staff);
        }

    }
}
