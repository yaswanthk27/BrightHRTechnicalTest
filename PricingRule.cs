using BrightHRTechnicalTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRTechnicalTest
{
    public static class PricingRule
    {       
         public static List<Product> GetProductRules()
        {
            return new List<Product> {
                new Product{Name='A', Price=50 },
                new Product{Name='B', Price=30 },
                new Product{Name='C', Price=20 },
                new Product{Name='D', Price=15 },
                new Product{Name='A', Price=130, Quantity=3 },
                new Product{Name='B', Price=45, Quantity=2 }
            };
        }
    }
}
