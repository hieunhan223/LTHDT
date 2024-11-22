using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.TemplateMethod
{
    internal class XL_PhanTuMaxAm:XL_PhanTuMax
    {
        public override bool ThoaDieuKien(int n)
        {
            return n<0;
        }
    }

    internal class XL_PhanTuMaxNguyenTo : XL_PhanTuMax
    {
        public override bool ThoaDieuKien(int n)
        {
            bool isPrime = false;
            int counter = 0;
            if (n <=1)
            {
                return isPrime;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2) isPrime = true;
                return isPrime;
            }            
        }
    }
    internal class XL_PhanTuMaxChan : XL_PhanTuMax
    {
        public override bool ThoaDieuKien(int n)
        {
            return n % 2 == 0;
        }
    }
}
