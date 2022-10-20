using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightHRTechnicalTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            assert_equal(0, price(""));
            assert_equal(50, price("A"));
            assert_equal(80, price("AB"));
            assert_equal(115, price("CDBA"));

            assert_equal(100, price("AA"));
            assert_equal(130, price("AAA"));
            assert_equal(180, price("AAAA"));
            assert_equal(230, price("AAAAA"));
            assert_equal(260, price("AAAAAA"));

            assert_equal(160, price("AAAB"));
            assert_equal(175, price("AAABB"));
            assert_equal(190, price("AAABBD"));
            assert_equal(190, price("DABABA"));
        }

    }
}
