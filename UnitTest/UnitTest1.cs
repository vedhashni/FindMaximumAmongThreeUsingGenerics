using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumProblem;
using System;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        FindMaxAmongThree<int> maxInt;

        FindMaxAmongThree<float> maxFloat;

        [TestInitialize]
        public void SetUp()
        {
            maxInt = new FindMaxAmongThree<int>(10, 20, 30);
            maxFloat = new FindMaxAmongThree<float>(1.2f, 3.5f, 6.7f);
        }
        [TestMethod]
        public void IntMethod()
        {
            int expected = 30;
            int actual = maxInt.TestMaximum();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestFloatMethod()
        {
            float expected = 6.7f;
            float actual = maxFloat.TestMaximum();
            Assert.AreEqual(expected, actual);
        
    }
    }
}
