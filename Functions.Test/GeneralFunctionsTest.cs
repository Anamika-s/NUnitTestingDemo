using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functions.Test
{
    [TestFixture]
    class GeneralFunctionsTest
    {
        [Test]
        public void GetDiscount1Test()
        {
            GeneralFunctions generalFunctions = new GeneralFunctions();
            string actual= generalFunctions.GetDiscount(70);
            Assert.AreEqual("Discount is 60%", actual);



        }

        [Author("Anamika")]
        [Description("This is to test GetDiscount Method")]
        [Ignore("The test methods are not completed")]
        [TestCase(30, "No Discount")]
        [TestCase(40, "Discount is 40%")]
        [TestCase(70, "Discount is 60%")]

        public void GetDiscountTest(int x, string expected)
        {
            GeneralFunctions generalFunctions = new GeneralFunctions();
            string actual = generalFunctions.GetDiscount(x);
            Assert.AreEqual(expected, actual);
        }
    }
}
