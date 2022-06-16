using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class WpfApp1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int input = 5;
            var calc = new Calc();
            int result = calc.sgrt(input);
            int expected = 25;
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public  void TestMethod2()
      {
        int input = 3;
        var calc = new Calc();
        int result = calc.sgrt(input);
        int expected = 9;
        Assert.AreEqual(expected, result);
      }
    }

    
}
