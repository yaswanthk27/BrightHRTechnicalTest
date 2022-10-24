using BrightHRTechnicalTest;
using BrightHRTechnicalTest.Models;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject
{
    public class CheckOutTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ScanTwoItems_OfSameProductType_ShouldAddAndReturnTotalPrice()
        {
            // arrange     
            CheckOut checkout = new CheckOut();

            // act
            checkout.Scan('A');
            checkout.Scan('A');

            // assert
            var totalPrice = checkout.GetTotalPrice();
            Assert.AreEqual(100, totalPrice);
        }

        [Test]
        public void ScanTwoItems_WithDifferentProductType_ShouldAddAndReturnTotalPrice()
        {
            // arrange
            CheckOut checkout = new CheckOut();

            // act
            checkout.Scan('A');
            checkout.Scan('B');

            // assert
            var totalPrice = checkout.GetTotalPrice();
            Assert.AreEqual(80, totalPrice);
        }

        [Test]
        public void ScanMultipleItems_OfSameProductType_ShouldAddDiscount()
        {
            // arrange
            CheckOut checkout = new CheckOut();

            // act 
            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('A');

            // assert
            var totalPrice = checkout.GetTotalPrice();
            Assert.AreEqual(310, totalPrice);
        }

        [Test]
        public void ScanMultipleItems_OfDiffProductType_ShouldAddItemsWithCorrectPrice()
        {
            // arrange
            CheckOut checkout = new CheckOut();

            // act 
            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('B');
            checkout.Scan('B');
            checkout.Scan('C');
            checkout.Scan('D');

            // assert
            var totalPrice = checkout.GetTotalPrice();
            Assert.AreEqual(210, totalPrice);
        }

        [Test]
        public void ScanItems_WithCustomPricingRule_ShouldAddTotalPriceAsPerNewRules()
        {
            // arrange            
            var rules = new List<Product>()
            {
                new Product{Name = 'A', Price = 20 },
                new Product{Name = 'A', Price = 30, Quantity = 2 }
            };
            CheckOut checkout = new CheckOut(rules);

            // act
            checkout.Scan('A');
            checkout.Scan('A');
            checkout.Scan('A');

            // assert
            var totalPrice = checkout.GetTotalPrice();
            Assert.AreEqual(50, totalPrice);
        }
    }
}



