using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.NewFolder
{
    internal class CongTy
    {
        //thanh phan du lieu
        public string Ten { get; set; }
        public NhanVien[] DanhSachNhanVien { get; set; }
        //thanh phan xu ly

        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            //nhap danh sach san xuat
            Console.WriteLine("Nhap so luong nhan vien: ");
            int n = int.Parse(Console.ReadLine());
            DanhSachNhanVien = new NhanVien[n];
            for (int i = 0; i < DanhSachNhanVien.Length; i++)
            {
                Console.WriteLine("Nhap loai nhan vien: 1.VP 2.SX ");
                int loai = int.Parse(Console.ReadLine());
                if (loai == 1)
                {
                    DanhSachNhanVien[i] = new NhanVienVanPhong();
                }
                else if (loai == 2)
                {
                    DanhSachNhanVien[i] = new NhanVienSanXuat();
                }
                DanhSachNhanVien[i].NhapNhanVien($"Nhap thong tin nhan vien thu {i + 1}");
            }
        }
        public int TinhTongLuong()
        {
            int tongLuong = 0;
            for (int i = 0; i < DanhSachNhanVien.Length; i++)
            {
                tongLuong = tongLuong + DanhSachNhanVien[i].TinhLuong();
            }

            return tongLuong;
        }
    }
}
