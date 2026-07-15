using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using equipment;
using equipment.Classes;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCheckEmailOk()
        {
            string email = "testEmail@mail.ru";
            bool expected = true;
            bool actual = Staff.CheckEmail(email);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodCheckEmailError()
        {
            string email = ".testEmail@mail.ru";
            bool expected = false;
            bool actual = Staff.CheckEmail(email);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodCheckPasswordOk()
        {
            string password = "Test.25";
            bool expected = true;
            bool actual = Staff.CheckPassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodCheckPasswordError()
        {
            string password = "testPassword";
            bool expected = false;
            bool actual = Staff.CheckPassword(password);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodCheckAccessUnblock()
        {
            string log = "staff1001-pap";
            string expected = "0";
            DBConnection.ConnectBD();
            string actual = Staff.CheckAccess(log);
            DBConnection.CloseBD();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodCheckAccessBlock()
        {
            string log = "staff1005-pav";
            string expected = "1";
            DBConnection.ConnectBD();
            string actual = Staff.CheckAccess(log);
            DBConnection.CloseBD();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethodCheckAddEquipmentOk()
        {

            bool expected = true;
            DBConnection.ConnectBD();
            bool actual = Equipments.Add("Acer Nitro 5", "1", "45000", "10");
            DBConnection.CloseBD();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodCheckAddEquipmentError()
        {
            bool expected = false;
            DBConnection.ConnectBD();
            bool actual = Equipments.Add("Acer Nitro 5", "99", "45000", "10");
            DBConnection.CloseBD();
            Assert.AreEqual(expected, actual);
        }
    }
}
