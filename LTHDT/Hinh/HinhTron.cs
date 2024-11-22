using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTHDT.Oxy;

namespace LTHDT.Hinh
{
    internal class HinhTron : Hinh
    {
        //Thanh phan du lieu
        public Diem I { get; set; }
        public double BanKinh { get; set; }

        //Thanh phan xu ly
        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu);
            I = new Diem();
            I.Nhap("Nhap tam I: ");
            Console.WriteLine("Nhap ban kinh: ");
            BanKinh = double.Parse(Console.ReadLine());
        }

        public override double TinhChuVi()
        {
            return Math.PI * BanKinh * BanKinh;
        }
    }
}
