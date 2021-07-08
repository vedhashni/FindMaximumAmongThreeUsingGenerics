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
        public void TestingFirstValue()
        {
            float first = 27.5f, second = 18.0f, third = 61.5f;
            float expected = first;

            float actual = three.FindMaxfloat(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingSecondValue()
        {
            float first = 35.2f, second = 45.2f, third = 72.3f;
            float expected = second;

            float actual = three.FindMaxfloat(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingThirdValue()
        {
            float first = 30.2f, second = 36.7f, third = 55.3f;
            float expected = third;

            float actual = three.FindMaxfloat(first, second, third);

            Assert.AreEqual(expected, actual);
        }
    }
}
