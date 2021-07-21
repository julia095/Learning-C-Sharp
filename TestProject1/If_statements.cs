using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class EqualityAndRelationShip
    {
        // variables to hold two int values
        static int number1;
        static int number2;

        [ClassInitialize]
        public static void IntegreInitialise(TestContext testContext)
        {
            number1 = 10;
            number2 = 5;
        }

        [TestMethod]
        public void Number1_Is_Equal_Number2()
        {
           Assert.IsTrue(number1 == number2);
        }

        [TestMethod]
        public void Number1_Is_Not_Equal_Number2()
        {
            Assert.IsTrue(number1 != number2);
        }

        [TestMethod]
        public void Number1_Is_Greater_Than_Number2()
        {
            Assert.IsTrue(number1 > number2);
        }
    }
}
