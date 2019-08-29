using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRM.Proeject.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Proeject.BL.Model.Tests
{
    [TestClass()]
    public class CartTests
    {
        [TestMethod()]
        public void CartTest()
        {
            // arrange
            var customer = new Customer()
            {
                CustomerId = 1,
                Name = "testuser"
            };
            var prod1 = new Product()
            {
                ProductId = 1,
                Name = "prod1",
                Price = 100,
                Count = 20
            };
            var prod2 = new Product()
            {
                ProductId = 2,
                Name = "prod2",
                Price = 150,
                Count = 30
            };
            var cart = new Cart(customer);
            
            var expectedResult = new List<Product>()
            {
                prod1, prod1, prod2
            };


            // act
            cart.Add(prod1);
            cart.Add(prod1);
            cart.Add(prod2);

            var cartResult = cart.GetAll();

            // assert

            Assert.AreEqual(expectedResult.Count, cartResult.Count);

            for (int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], cartResult[i]);
            }

        }
    }
}