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
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            // arrange

            var customer1 = new Customer()
            {
                CustomerId = 1,
                Name = "testCustomer1"
            };

            var customer2 = new Customer()
            {
                CustomerId = 2,
                Name = "testCustomer2"
            };

            var seller = new Seller()
            {
                SellerId = 1,
                Name = "testSeller"
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
            var cart1 = new Cart(customer1);
            cart1.Add(prod1);
            cart1.Add(prod1);
            cart1.Add(prod2);
            
            var cart2 = new Cart(customer2);
            cart2.Add(prod1);
            cart2.Add(prod1);
            cart2.Add(prod2);
            cart2.Add(prod2);


            var cashDask = new CashDesk(1, seller);
            cashDask.MaxQueueLength = 4;
            cashDask.Enqueue(cart1);
            cashDask.Enqueue(cart2);

            var cart1ExpectedResult = 350;
            var cart2ExpectedResult = 500;

            // act

            var cart1ActualResult = cashDask.Dequeue();
            var cart2ActualResult = cashDask.Dequeue();


            //Assert

            Assert.AreEqual(cart1ExpectedResult, cart1ActualResult);
            Assert.AreEqual(cart2ExpectedResult, cart2ActualResult);
            Assert.AreEqual(16, prod1.Count);
            Assert.AreEqual(27, prod2.Count);
        }

        [TestMethod()]
        public void EnqueueTest()
        {
            
        }

        [TestMethod()]
        public void DequeueTest()
        {
            
        }
    }
}