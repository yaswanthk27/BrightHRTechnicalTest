using BrightHRTechnicalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRTechnicalTest
{
    public class CheckOut:ICheckOut
    {

        private readonly List<Product> _pricingRules;
        private List<char> _items;

        public  CheckOut()
        {
            _pricingRules = PricingRule.GetProductRules();
            _items = new List<char>();
        }

        public CheckOut(List<Product> pricingRules)
        {
            _pricingRules = pricingRules.Any() ? pricingRules : PricingRule.GetProductRules();
            _items = new List<char>();
        }
        public void Scan(char item)
        {
            _items.Add(item);
        }
        public decimal GetTotalPrice()
        {
            decimal checkoutTotal = 0;
            var itemsGroup = _items.GroupBy(item => item);

            foreach (var items in itemsGroup)
            {
                var scanedItemsCount = items.Count();
                var productsWithQuantityOrder = _pricingRules.Where(product => product.Name.ToString().Equals(items.Key.ToString(), StringComparison.InvariantCultureIgnoreCase)).OrderByDescending(p => p.Quantity);
                var pricingRuleQuantity = productsWithQuantityOrder.First().Quantity;

                if (productsWithQuantityOrder.Any() && scanedItemsCount >= pricingRuleQuantity)
                {
                    while (scanedItemsCount >= pricingRuleQuantity)
                    {
                        checkoutTotal += productsWithQuantityOrder.First().Price;
                        scanedItemsCount -= pricingRuleQuantity;
                    }
                    checkoutTotal += scanedItemsCount * productsWithQuantityOrder.Last().Price;
                }
                else
                {
                    checkoutTotal += scanedItemsCount * productsWithQuantityOrder.Last().Price;
                }
            }

            return checkoutTotal;
        }


    }

}
