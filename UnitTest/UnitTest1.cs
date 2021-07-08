using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblem;
using System;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        FindMaxAmongThree three;
        
        [TestInitialize]
        public void SetUp()
        {
            three = new FindMaxAmongThree();
        }
        [TestMethod]
        public void TestingFirstString()
        {
            string first = "Orange", second = "Apple", third = "Mango";
            string expected = first;

            String actual = three.FindMaxString(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingSecondString()
        {
            string first = "Mango", second = "Orange", third = "Apple";
            string expected = second;

            String actual = three.FindMaxString(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingThirdString()
        {
            string first = "Mango", second = "Apple", third = "Orange";
            string expected = third;


            String actual = three.FindMaxString(first, second, third);

            Assert.AreEqual(expected, actual);
        }
    }
}
