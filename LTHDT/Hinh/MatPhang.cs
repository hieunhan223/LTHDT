using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.Hinh
{
    internal class MatPhang
    {
        //Thanh phan du lieu
        public Hinh[] DanhSachHinh { get; set; }

        //Thanh phan xu ly

        public void Nhap(string ghiChu)
        {
            Console.WriteLine("Nhap so luong hinh : ");
            int n = int.Parse(Console.ReadLine());
            DanhSachHinh = new Hinh[n];
            for (int i = 0; i < n; i++)
            {
                DanhSachHinh[i] = new HinhTron();

                DanhSachHinh[i].Nhap($"Nhap thong tin hinh thu {i + 1}:");
            }


        }

        public double TinhTongChuVi()
        {
            double tongChuVi = 0;
            for (int i = 0; i < DanhSachHinh.Length; i++)
            {
                tongChuVi += DanhSachHinh[i].TinhChuVi();
            }

            return tongChuVi;
        }
    }
}
