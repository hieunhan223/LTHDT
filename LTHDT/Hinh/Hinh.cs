using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.Hinh
{
    internal class Hinh
    {
        //Thanh phan du lieu
        public string MauSac { get; set; }

        //Thanh phan xu ly
        public virtual void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap mau sac cua hinh: ");
            MauSac = Console.ReadLine();

        }
        public virtual double TinhChuVi()
        {
            return 0;
        }
    }
}
