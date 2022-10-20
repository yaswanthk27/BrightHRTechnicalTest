using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRTechnicalTest
{
    public class CheckOut
    {
        private PricingRule[] _pricingRules;
        private List<char> _items;

        public Checkout(IEnumerable<PricingRule> pricingRules)
        {
            _pricingRules = pricingRules.ToArray();
            _items = new List<char>();
        }
    }
    public class PricingRule
    {
        public readonly char Item;
        public readonly int Count;
        public readonly decimal Price

    }
}
