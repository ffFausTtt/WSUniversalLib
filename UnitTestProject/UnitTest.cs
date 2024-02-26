using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {

        [TestMethod]
        public void TestMethodAreEqual_true_1()
        {
            // метод, подтверждающий, что фактический результат  равен ожидаемому
            int productType = 5, materialType = 1, count = 15;
            int width = 20, length = 45;
            int except = -1;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void TestMethodAreEqual_true_3()
        {
            // метод, подтверждающий, что фактический результат  равен ожидаемому
            int productType = 2, materialType = 1, count = 20;
            int width = 15, length = 30;
            int except = 22568;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]

        public void TestMethodAreEqual_true()
        {

            // метод, подтверждающий, что фактический результат  равен ожидаемому
            int productType = 3, materialType = 1, count = 15;
            int width = 20, length = 45;
            int except = 114147;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreEqual(except, actual);
        }

        [TestMethod]
        public void TestMethodAreNotEqual_true()
        {
            // метод, подтверждающий, что фактический результат  равен ожидаемому
            int productType = 3, materialType = 1, count = 15;
            int width = 20, length = 45;
            int except = 114148;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.AreNotEqual(except, actual);
        }

        [TestMethod]
        public void TestMethodIsTrue_true()
        {
            // метод, подтверждающий, что фактический результат  равен ожидаемому
            int productType = 3, materialType = 1, count = 15;
            int width = 20, length = 45;
            int except = 114147;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsTrue(actual == except);
        }
        [TestMethod]
        public void TestMethodIsFalse_False()
        {
            // метод, подтверждающий, что фактический результат не равен ожидаемому
            int productType = 3, materialType = 1, count = 15;
            float width = 20, length = 45;
            int except = 114148;
            int actual = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsFalse(actual == except);

        }
        [TestMethod]
        public void TestMethodIsType_trueInt()
        {
            // метод, подтверждающий, что мы ожидаем int

            int productType = 3, materialType = 1, count = 15;
            int width = 20, length = 45;
            int except = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsInstanceOfType(except, typeof(int));
        }
        [TestMethod]
        public void TestMethodIsType_falseDouble()
        {
            // метод, подтверждающий, что не мы ожидаем int,  а ожидаем double
            int productType = 3, materialType = 1, count = 15;
            int width = 20, length = 45;
            int except = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotInstanceOfType(except, typeof(double));
        }
        [TestMethod]
        public void TestMethodIsType_falseString()
        {
            // метод, подтверждающий, что не мы ожидаем int,  а ожидаем double
            int productType = 3, materialType = 1, count = 15;
            int width = 20, length = 45;
            int except = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotInstanceOfType(except, typeof(string));
        }
        [TestMethod]
        public void TestMethodIsNotNull_true()
        {
            int productType = 3, materialType = 1, count = 15;
            int width = 20, length = 45;
            int except = Calculation.GetQuantityForProduct(productType, materialType, count, width, length);
            Assert.IsNotNull(except);
        }
        // сложные
        [TestMethod]
        public void TestMethodIsNotNull123()
        {
            int productType = 1, materialType = -31231, count = -3;
            int width = 20, length = 45;
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Calculation.GetQuantityForProduct(productType, materialType, count, width, length)));
        }
        [TestMethod]
        public void TestMethodIsNotNull1235()
        {
            int productType = 0, materialType = 0, count = 0;
            int width = 20, length = 45;
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Calculation.GetQuantityForProduct(productType, materialType, count, width, length)));
        }
        [TestMethod]
        public void TestMethodIsNotNull1234()
        {
            int productType = 2147483647, materialType = 2147483647, count = 2147483647;
            int width = 15, length = 35;
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Calculation.GetQuantityForProduct(productType, materialType, count, width, length)));
        }
        [TestMethod]
        public void TestMethodIsNotNull123456()
        {
            int productType = 0, materialType = 2147483647, count = 2147483647;
            int width = 205, length = -1;
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Calculation.GetQuantityForProduct(productType, materialType, count, width, length)));
        }
        [TestMethod]
        public void TestMethodIsNotNull1234567()
        {
            int productType = 0, materialType = 2147483647, count = -2;
            int width = 0, length = 15;
            Assert.ThrowsException<AssertFailedException>(() => Assert.ThrowsException<SystemException>(() => Calculation.GetQuantityForProduct(productType, materialType, count, width, length)));
        }
    }
}
