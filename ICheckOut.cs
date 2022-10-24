using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRTechnicalTest
{
    public interface ICheckOut
    {
        void Scan(char item);
        decimal GetTotalPrice();
    }
}
