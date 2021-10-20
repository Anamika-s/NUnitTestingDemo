using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functions.Test
{
    [TestFixture]
    class CustomerTest
        
    {
        [Test]
        public void AddCustomerTest()
        {
           
            Mock<Email> obj = new Mock<Email>();
            obj.Setup(x => x.sendMail()).Returns(true);
            Customer customer = new Customer();
            bool actual = customer.AddCustomer(obj.Object);
            Assert.AreEqual(true, actual);
        }
    }
}
