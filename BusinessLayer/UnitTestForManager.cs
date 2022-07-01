using System;
using System.Reflection;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLayer
{
    [TestClass]
    public class UnitTestForManager
    {
        [TestMethod] // checkout PaymentManager.cs to see why this test fails
        public void TestPaymentExtraDetailManager()
        {
            Assert.AreEqual("tblPaymentExtraDetail", PaymentExtraDetailManager.TableName);
            Assert.AreEqual("PaymentExtraDetailManager", PaymentExtraDetailManager.ManagerName);
        }

        [TestMethod]
        public void TestChatManager()
        {
            Assert.AreEqual("tblChat", ChatManager.TableName);
            Assert.AreEqual("ChatManager", ChatManager.ManagerName);
        }

        [TestMethod]
        public void TestUserManager()
        {
            Assert.AreEqual("tblUser", UserManager.TableName);
            Assert.AreEqual("UserManager", UserManager.ManagerName);
        }

        [TestMethod]
        public void TestPaymentManager()
        {
            Assert.AreEqual("tblPayment", PaymentManager.TableName);
            Assert.AreEqual("PaymentManager", PaymentManager.ManagerName);
        }

    }
}


