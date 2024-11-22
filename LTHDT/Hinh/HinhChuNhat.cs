using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTHDT.Oxy;

namespace LTHDT.Hinh
{
    internal class HinhChuNhat : Hinh
    {
        public Diem Dinh { get; set; }
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }

        public override void Nhap(string ghiChu)
        {
            base.Nhap(ghiChu);
            Dinh = new Diem();
            Dinh.Nhap("Nhap toa do dinh A: ");
            Console.WriteLine("Nhap chieu dai: ");
            ChieuDai = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            ChieuRong = double.Parse(Console.ReadLine());
        }

        public double TinhChuVi()
        {
            return (ChieuDai + ChieuRong) * 2;
        }
    }
}
