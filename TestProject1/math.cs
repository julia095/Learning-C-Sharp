using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class math
    {
        [TestMethod]
        public void Convert_F_To_C()
        {
            double valueInFarenheit;
            double valueInCelsium;
            // set value
            valueInFarenheit = 37;
            // convert
            valueInCelsium = (valueInFarenheit - 32) * 0.5556;
            // print out "The temp in F {valueInFaraanheit} is {valueInelsium} in C"
            string response = $"The temp in F {valueInFarenheit} is {valueInCelsium} in C";
            Console.WriteLine(response);
            // assert
            Assert.AreEqual(valueInCelsium, 2.778, 0.001);
        }

    }
}
