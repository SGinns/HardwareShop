using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareClasses;

namespace HardwareTesting
{
    /**
     * Unit tests for the Staff class (clsStaff)
     * @author Joe
     */
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staffMember = new clsStaff();
            Assert.IsNotNull(staffMember);
        }

        
        [TestMethod]
        public void FindMethodOK()
        {
            // Create New Instance of class
            clsStaff staffMember = new clsStaff();
            // Var to store result of method
            Boolean found = false;
            // Employee no to search for 
            int employeeNo = 1;
            // Use the find method
            found = staffMember.find(employeeNo);

            Assert.IsTrue(found);
            
        }

        [TestMethod]
        public void TestEmployeeNoFound()
        {
            // Create New instance of staff
            clsStaff staffMember = new clsStaff();
            // Var to store result of method
            Boolean found = false;
            // Var to keep track if data is right
            Boolean OK = true;
            // Employee no to search for
            Int32 employeeNo = 1;
            // Use the find method
            found = staffMember.find(employeeNo);
            // Check the pulled data
            if (staffMember.EmployeeNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            // Create New instance of staff
            clsStaff staffMember = new clsStaff();
            // Var to store result of method
            Boolean found = false;
            // Var to keep track if data is right
            Boolean OK = true;
            // salary to search for
            Int32 salary = 15000;
            // Use the find method
            found = staffMember.find(1);
            // Check the pulled data
            if (staffMember.salary != salary)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            // Create New instance of staff
            clsStaff staffMember = new clsStaff();
            // Var to store result of method
            Boolean found = false;
            // Var to keep track if data is right
            Boolean OK = true;
            // salary to search for
            String firstName = "Joe";
            // Use the find method
            found = staffMember.find(1);
            // Check the pulled data
            if (staffMember.first_name != firstName)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            // Create New instance of staff
            clsStaff staffMember = new clsStaff();
            // Var to store result of method
            Boolean found = false;
            // Var to keep track if data is right
            Boolean OK = true;
            // salary to search for
            string lastName = "Edwards";
            // Use the find method
            found = staffMember.find(1);
            // Check the pulled data
            if (staffMember.last_name != lastName)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            // Create New instance of staff
            clsStaff staffMember = new clsStaff();
            // Var to store result of method
            Boolean found = false;
            // Var to keep track if data is right
            Boolean OK = true;
            // salary to search for
            Boolean active = true;
            // Use the find method
            found = staffMember.find(1);
            // Check the pulled data
            if (staffMember.active != active)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCreatedAtFound()
        {
            // Create New instance of staff
            clsStaff staffMember = new clsStaff();
            // Var to store result of method
            Boolean found = false;
            // Var to keep track if data is right
            Boolean OK = true;
            // salary to search for
            DateTime createdAt = Convert.ToDateTime("01/01/2020") ;
            // Use the find method
            found = staffMember.find(1);
            // Check the pulled data
            if (staffMember.created_at != createdAt)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        //  Test will pass if validation fails
        [TestMethod]
        public void TestValidSalaryNegative()
        {
            // Generate a new staff object with the factory
            clsStaff staff = new clsStaffFactory().MakeNewStaffObj();

            // Hold an empty string to simulate error string
            string error = "";

            // Set salary on object
            staff.salary = -100;

            // Call the test method
            error = staff.Valid(staff.salary, staff.first_name, staff.last_name, staff.active);

            Assert.AreNotEqual("", error);

        }


        [TestMethod]
        public void TestValidPass()
        {
            // Generate a new staff object with the factory
            clsStaff staff = new clsStaffFactory().MakeNewStaffObj(); // Should already be a valid object

            // Hold an empty string to simulate error string
            string error = "";

            // Call the test method
            error = staff.Valid(staff.salary, staff.first_name, staff.last_name, staff.active);

            if (error != "")
            {
                Console.WriteLine("Test failed with " + error);
            }

            Assert.AreEqual("", error);

        }

        [TestMethod]
        public void TestSalaryNullValid()
        {
            // Generate a new staff object with the factory
            clsStaff staff = new clsStaffFactory().MakeNewStaffObj(); // Should already be a valid object

            // Hold an empty string to simulate error string
            string error = "";

            staff.salary = 0;

            // Call the test method
            error = staff.Valid(staff.salary, staff.first_name, staff.last_name, staff.active);

            Assert.AreNotEqual("", error);

        }

        [TestMethod]
        public void TestFirstNameEmptyValid()
        {
            // Generate a new staff object with the factory
            clsStaff staff = new clsStaffFactory().MakeNewStaffObj(); // Should already be a valid object

            // Hold an empty string to simulate error string
            string error = "";

            staff.first_name = "";

            // Call the test method
            error = staff.Valid(staff.salary, staff.first_name, staff.last_name, staff.active);

            Assert.AreNotEqual("", error);

        }

        [TestMethod]
        public void TestFirstNameSpaceStringValid()
        {
            // Generate a new staff object with the factory
            clsStaff staff = new clsStaffFactory().MakeNewStaffObj(); // Should already be a valid object

            // Hold an empty string to simulate error string
            string error = "";

            staff.first_name = " ";

            // Call the test method
            error = staff.Valid(staff.salary, staff.first_name, staff.last_name, staff.active);

            Assert.AreNotEqual("", error);

        }

        [TestMethod]
        public void TestLastNameEmptyValid()
        {
            // Generate a new staff object with the factory
            clsStaff staff = new clsStaffFactory().MakeNewStaffObj(); // Should already be a valid object

            // Hold an empty string to simulate error string
            string error = "";

            staff.last_name = "";

            // Call the test method
            error = staff.Valid(staff.salary, staff.first_name, staff.last_name, staff.active);

            Assert.AreNotEqual("", error);

        }

        [TestMethod]
        public void TestLastNameSpaceStringValid()
        {
            // Generate a new staff object with the factory
            clsStaff staff = new clsStaffFactory().MakeNewStaffObj(); // Should already be a valid object

            // Hold an empty string to simulate error string
            string error = "";

            staff.last_name = " ";

            // Call the test method
            error = staff.Valid(staff.salary, staff.first_name, staff.last_name, staff.active);

            Assert.AreNotEqual("", error);

        }


    }
}
