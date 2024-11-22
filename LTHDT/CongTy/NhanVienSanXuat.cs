using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.NewFolder
{
    internal class NhanVienSanXuat : NhanVien
    {
        //thanh phan du lieu
        public int SoSanPham { get; set; }

        //thanh phan xu ly
        public override void NhapNhanVien(string ghiChu)
        {
            base.NhapNhanVien(ghiChu); //Call method from Inheritance class          
            Console.WriteLine("Nhap so San Pham: ");
            SoSanPham = int.Parse(Console.ReadLine());
        }
        public override int TinhLuong()
        {
            return SoSanPham * 100;
        }
    }
}
