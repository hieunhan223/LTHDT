using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTHDT.Oxy;

namespace LTHDT
{
    public class TamGiac
    {
        public Diem A;
        public Diem B; 
        public Diem C;

        //Ham tao: co ten ham trung voi ten lop, dung de khoi tao gia tri ban dau
        public TamGiac() 
        {
            A = new Diem(0, 0);
            B = new Diem(0, 1);
            C = new Diem(1, 0);
        }

        public TamGiac(Diem dinhA, Diem dinhB, Diem dinhC)
        {
            double a, b, c;
            a = dinhA.TinhKhoangCach(dinhB);
            b = dinhA.TinhKhoangCach(dinhC);
            c = dinhB.TinhKhoangCach(dinhC);
            if(a+b<=c||a+c<=b||b+c<=a)
            {
                throw new Exception("Du lieu khong hop le");
            }
            A = dinhA;
            B = dinhB;
            C = dinhC;
        }
    
        public void Nhap(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            A = new Diem();
            A.Nhap("Nhap dinh A: ");
            B = new Diem();
            B.Nhap("Nhap dinh B: ");
            C = new Diem();
            C.Nhap("Nhap dinh C: ");
        }
        public double TinhChuVi()
        {
            double kq = A.TinhKhoangCach(B) + A.TinhKhoangCach(C) + B.TinhKhoangCach(C);
            return kq;
        }
    }
}
