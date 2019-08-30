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
                Name = "testUser"
            };
            var product1 = new Product()
            {
                ProductId = 1,
                Name = "pr1",
                Price = 100,
                Count = 20
            };
            var product2 = new Product()
            {
                ProductId = 2,
                Name = "prod2",
                Price = 150,
                Count = 30
            };
            var cart = new Cart(customer);
            
            var expectedResult = new List<Product>()
            {
                product1, product1, product2
            };


            // act
            cart.Add(product1);
            cart.Add(product1);
            cart.Add(product2);

            var cartResult = cart.GetAll();

            // assert

            Assert.AreEqual(expectedResult.Count, cartResult.Count);
            for(int i = 0; i < expectedResult.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], cartResult[i]);
            }

        }
    }
}