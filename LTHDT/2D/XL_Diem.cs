using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.Oxy
{
    public class Diem
    {
        public int X;
        public int Y;
        public int Z;
        public Diem()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Diem(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Diem(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap toa do x:");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap toa do y:");
            Y = int.Parse(Console.ReadLine());
        }

        public double TinhKhoangCach(Diem y)
        {
            return Math.Sqrt((X - y.X) * (X - y.X) + (Y - y.Y) * (Y - y.Y));
        }
    }
}
