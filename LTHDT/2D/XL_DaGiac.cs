using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.Oxy
{

    internal class DaGiac
    {
        private Diem[] _dsDinh;
        public DaGiac()
        {
            _dsDinh = new Diem[3];
            _dsDinh[0] = new Diem(0, 0);
            _dsDinh[1] = new Diem(0, 1);
            _dsDinh[2] = new Diem(1, 0);
        }
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            int n;
            do
            {
                Console.WriteLine("Nhap so luong dinh: ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 3);

            _dsDinh = new Diem[n];
            for (int i = 0; i < n; i++)
            {
                _dsDinh[i] = new Diem();
                _dsDinh[i].Nhap($"Nhap dinh a[{i}]");
            }
        }
        public double TinhChuVi()
        {
            double chuVi = 0;
            for (int i = 0; i < _dsDinh.Length - 1; i++)
            {
                double canh = _dsDinh[i].TinhKhoangCach(_dsDinh[i + 1]);
                chuVi = chuVi + canh;
            }

            chuVi = chuVi + _dsDinh[0].TinhKhoangCach(_dsDinh[_dsDinh.Length - 1]);
            return chuVi;
        }

    }
}
