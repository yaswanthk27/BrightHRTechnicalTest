using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRTechnicalTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            CheckOut checkout = new CheckOut();

            char[] productsInCart = { 'A', 'A', 'B', 'B', 'A' };

            foreach (char item in productsInCart)
            {
                checkout.Scan(item);
            }

            Console.WriteLine(checkout.GetTotalPrice());
            Console.ReadLine();
        }

    }
}
