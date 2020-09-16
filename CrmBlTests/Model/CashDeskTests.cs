using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBl.Model.Tests
{
    [TestClass()]
    public class CashDeskTests
    {
        [TestMethod()]
        public void CashDeskTest()
        {
            //arrange
            var customer1 = new Customer()
            {
                Name = "testuser1",
                CustomerId = 1
            };
            var customer2 = new Customer()
            {
                Name = "testuser2",
                CustomerId = 2
            };
            var seller = new Seller()
            {
                Name = "sellername",
                SellerId = 1
            };

            var product1 = new Product
            {
                ProductId = 1,
                Name = "pr1",
                Price = 10,
                Count = 10

            };
            var product2 = new Product
            {
                ProductId = 2,
                Name = "pr2",
                Price = 100,
                Count = 20

            };
            var cart1 = new Cart(customer1);
            cart1.Add(product1);
            cart1.Add(product1);
            cart1.Add(product2);

            var cart2 = new Cart(customer2);
            cart2.Add(product1);
            cart2.Add(product2);
            cart2.Add(product2);

            var cashdesk = new CashDesk(1, seller, null);
            cashdesk.MaxQueueLenght = 10;
            cashdesk.Enqueue(cart1);
            cashdesk.Enqueue(cart2);

            var cart1ExpectedResult = 120;
            var cart2ExpectedResult = 210;

            //act
            var cart1ActualResult = cashdesk.Dequeu();
            var cart2ActualResult = cashdesk.Dequeu();
            //assert
            Assert.AreEqual(cart1ExpectedResult, cart1ActualResult);
            Assert.AreEqual(cart2ExpectedResult, cart2ActualResult);
            Assert.AreEqual(7, product1.Count);
            Assert.AreEqual(17, product2.Count);
        }

    }
}