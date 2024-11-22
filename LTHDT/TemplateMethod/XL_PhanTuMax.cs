using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.TemplateMethod
{
    //template method
    internal abstract class XL_PhanTuMax
    {
        public int TimPhanTuMax(int[] a)
        {
            int maxIndex = -1;
            for (int i = 0; i < a.Length; i++)
            {
                if (ThoaDieuKien(a[i]))
                {
                    maxIndex = i;
                    break;
                }
            }
            //Neu ton tai so am
            if (maxIndex >= 0)
            {
                for (int i = maxIndex; i < a.Length; i++)
                {
                    if (ThoaDieuKien(a[i]))
                    {
                        if (a[i] > a[maxIndex])
                        {
                            maxIndex = i;
                        }
                    }
                }
            }
            return maxIndex;
        }
        public abstract bool ThoaDieuKien(int n);
    }
}
