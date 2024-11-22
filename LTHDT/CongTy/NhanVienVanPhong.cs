using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.NewFolder
{
    internal class NhanVienVanPhong : NhanVien
    {
        //thanh phan du lieu

        public int HeSoLuong { get; set; }
        public int PhuCap { get; set; }

        //thanh phan xu ly
        public override void NhapNhanVien(string ghiChu) //override method from Inheritance class
        {
            base.NhapNhanVien(ghiChu);
            Console.WriteLine("Nhap so He So Luong: ");
            HeSoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so Phu Cap: ");
            PhuCap = int.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            return HeSoLuong * 100000 + PhuCap;
        }
    }
}
