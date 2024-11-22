using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT.NewFolder
{
    internal class NhanVien
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string CCCD { get; set; }

        public virtual void NhapNhanVien(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.WriteLine("Nhap ten: ");
            Ten = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            DiaChi = Console.ReadLine();
            Console.WriteLine("Nhap CCCD: ");
            CCCD = Console.ReadLine();
        }
        public virtual int TinhLuong()
        {
            return 0;
        }
    }
}
