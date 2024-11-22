using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTHDT
{
    public class LOPPHANSO
    {
        //Cac thanh phan du lieu 
        private int TuSo;
        private int MauSo;
        public int _tuSo
        {
            get;set;
        }

        //Cac thanh phan xu ly
        //Ham tao: co ten ham trung voi ten lop, dung de khoi tao gia tri ban dau
        public LOPPHANSO() 
        {
            TuSo =  0;
            MauSo = 1;
        }
        public LOPPHANSO(int tuSo, int mauSo)
        {
            if (mauSo==0)
            {
                throw new Exception("Du lieu khong hop le");
            }
            TuSo = tuSo;
            MauSo = mauSo;
        }

        public void NhapPhanSo (String  ghiChu)
        {
            Console.WriteLine(ghiChu);
            Console.Write("Nhap tu so:");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so:");
            MauSo = int.Parse(Console.ReadLine());
        }
        public LOPPHANSO CongvoiPhanSo(LOPPHANSO b)
        {
            LOPPHANSO kq = new LOPPHANSO();
            kq.TuSo = TuSo * b.MauSo + MauSo * b.TuSo;
            kq.MauSo = MauSo * b.MauSo;
            return kq;
        }
        public string Xuat()
        {
            return $"{TuSo}/{MauSo}";
        }
    }
}
