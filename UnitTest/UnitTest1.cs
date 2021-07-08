﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        public void TestingFirstValue()
        {
            int first = 70, second = 35, third = 67;
            int expected = first;

            int actual = three.FindMaximum(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingSecondValue()
        {
            int first = 15, second = 20, third = 17;
            int expected = second;

            int actual = three.FindMaximum(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingThirdValue()
        {
            int first = 30, second = 60, third = 90;
            int expected = third;

            int actual = three.FindMaximum(first, second, third);

            Assert.AreEqual(expected, actual);
        }
    }
}
