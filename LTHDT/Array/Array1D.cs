using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.Array
{
    internal class Array1D<T>
    {
        //thanh phan du lieu
        private T[] items;
        public Array1D()
        {
            items = null;
        }

        //thanh phan xu ly
        public void Add (T value)
        {
            if (items  == null)
            {
                items = new T[] { value };
            }
            else
            {
                T[] newItems = new T[items.Length+1];
                for (int i=0; i<items.Length; i++)
                {
                    newItems[i] = items[i];
                }
                newItems[newItems.Length - 1] = value;
                items = newItems;
            }
        }

        public void XuatMang()
        {
            if (items != null)
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
