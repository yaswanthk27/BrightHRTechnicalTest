﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRTechnicalTest.Models
{
    public class Product
    {

        public Product()
        {
            Quantity = 1;
        }
        public char Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
       
    }
}
