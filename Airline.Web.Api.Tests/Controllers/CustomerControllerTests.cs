using Airline.Web.Api.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Airline.Web.Api.Tests.Controllers
{
    [TestClass]
    public class CustomerControllerTests
    {
        private readonly CustomerController sut;

        public CustomerControllerTests()
        {
            sut = new CustomerController();
        }

        [TestMethod]
        public void Get_ShouldReturnOneCustomer()
        {
            var customers = sut.Get();

            Assert.IsNotNull(customers);
            Assert.AreEqual(1, customers.Count());
            Assert.AreEqual("test@test.com", customers.FirstOrDefault().Email);
        }
    }
}
