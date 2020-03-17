using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareClasses;

namespace HardwareTesting
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }


        

        public bool Find(int customerId)
        {
            return true;
        }


        


        [TestMethod]
        public void CustomerIDPropertyOK()
        {
            clsCustomer CustomerID = new clsCustomer();
            int TestData = 1;
            CustomerID.CustomerId = TestData;
            Assert.AreEqual(CustomerID.CustomerId, TestData);
        }



        [TestMethod]
        public void UsernamePropertyOK()
        {
            clsCustomer Username = new clsCustomer();
            string TestData = "testing";
            Username.UsernameId = TestData;
            Assert.AreEqual(Username.UsernameId, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsCustomer Password = new clsCustomer();
            String TestData = "Password";
            Password.password = TestData;
            Assert.AreEqual(Password.password, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()
        {
            clsCustomer EmailAddress = new clsCustomer();
            string TestData = "EmailAddress@email.com";
            EmailAddress.emailaddress = TestData;
            Assert.AreEqual(EmailAddress.emailaddress, TestData);
        }

        [TestMethod]
        public void AddresPropertyOK()
        {
            clsCustomer Address = new clsCustomer();
            string TestData = "21 Clephan street";
            Address.address = TestData;
            Assert.AreEqual(Address.address, TestData);
        }


        [TestMethod]
        public void EmailVerificationPropertyOK()
        {
            clsCustomer EmailVerification = new clsCustomer();
            string TestData = "email";
            EmailVerification.emailverification = TestData;
            Assert.AreEqual(EmailVerification.emailverification, TestData);
        }

        [TestMethod]
        public void DateOfBirthPropertyOK()
        {
            clsCustomer DateOfBirth = new clsCustomer();
            DateTime TestData = Convert.ToDateTime("13/01/2020");
            DateOfBirth.dateofbirth = TestData;
            Assert.AreEqual(DateOfBirth.dateofbirth, TestData);
        }



        /* FIND METHOD*/ 

        [TestMethod]
        public void FindMethodOk()
        {

            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 1;
            Found = ACustomer.find(CustomerId);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void CustomerIDFound()
        {
            clsCustomer CustomerID = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = CustomerID.Find(CustomerId);
            if(CustomerID.CustomerId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



        [TestMethod]

        public void UsernameFound()
        {
            clsCustomer Username = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = Username.Find(CustomerId);
            if (Username.UsernameId != "1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void EmailAddressFound()
        {
            clsCustomer EmailAddress = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = EmailAddress.Find(CustomerId);
            if (EmailAddress.emailaddress != "test")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void AddressFound()
        {
            clsCustomer Address = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = Address.Find(CustomerId);
            if (Address.address != "test")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]

        public void DateOfBirthFound()
        {
            clsCustomer DateOfBirth = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            Found = DateOfBirth.Find(CustomerId);
            if (DateOfBirth.dateofbirth != Convert.ToDateTime("01/0/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


                     

        //{
            
        //int testdata = 1;
        //customerid.customerid = testdata;
        //    assert.areequal(customerid.customerid, testdata);
        //}






}
}
