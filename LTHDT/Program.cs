// See https://aka.ms/new-console-template for more information

using LTHDT.Array;
using LTHDT.File;
using LTHDT.NewFolder;
using LTHDT.TemplateMethod;

namespace LTHDT
{
    internal class Program
    {        static void Main(string[] args)
        {
            Array1D<int> mangSoNguyen = new Array1D<int>();
            mangSoNguyen.Add(1);
            mangSoNguyen.Add(2);
            mangSoNguyen.Add(3);
            mangSoNguyen.XuatMang();

            Array1D<double> mangSoThuc = new Array1D<double>();
            mangSoThuc.Add(1.1);
            mangSoThuc.Add(2.1);
            mangSoThuc.Add(3.1);
            mangSoThuc.XuatMang();
            /*
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            XL_PhanTuMaxNguyenTo xuly = new XL_PhanTuMaxNguyenTo();
            int kq = xuly.TimPhanTuMax(a);
            Console.WriteLine(kq);
            /*
            ThuMuc vn = new ThuMuc("VN");
            ThuMuc mienBac = new ThuMuc("Mien Bac");
            ThuMuc mienTrung = new ThuMuc("Mien Trung");
            ThuMuc mienNam = new ThuMuc("Mien Nam");

            vn.AddChild(mienBac);
            vn.AddChild(mienTrung);
            vn.AddChild(mienNam);

            mienBac.AddChild(new ThuMuc("Ha Noi"));
            mienBac.AddChild(new ThuMuc("Hai Phong"));
            mienBac.AddChild(new TapTin("mienbac.txt",100));

            mienTrung.AddChild(new ThuMuc("Ha Noi"));
            mienTrung.AddChild(new TapTin("mientrung1.txt", 2000));
            mienTrung.AddChild(new TapTin("mientrung2.txt", 1000));

            ThuMuc tphcm = new ThuMuc("TPHCM");
            mienNam.AddChild(tphcm);
            mienNam.AddChild(new TapTin("miennam.txt", 5000));

            tphcm.AddChild(new TapTin("quan1", 100));

            int sum = vn.GetSize();
            Console.WriteLine(sum);
            /*
            CongTy congTy = new CongTy();
            congTy.Nhap("Nhap thong tin cong ty");
            Console.WriteLine(congTy.TinhTongLuong());
            //XU LY XXXXXXXXXXX 
            //B1. Tao lap cac doi tuong can thiet
            //B2. Yeu cau doi tuong thuc hien hanh dong
            //B3. Xuat ket qua
            */

            /*//XU LY PHAN SO 
            //B1. Tao lap cac doi tuong can thiet
            LOPPHANSO a = new LOPPHANSO();
            LOPPHANSO b = new LOPPHANSO();
            LOPPHANSO kq1 = new LOPPHANSO();
            //B2. Yeu cau doi tuong thuc hien hanh dong
            a.NhapPhanSo("Nhap phan so a:");
            b.NhapPhanSo("Nhap phan so b:");
            kq1 = a.CongvoiPhanSo(b);
            //B3. Xuat ket qua
            string chuoi1 = "Ket qua la " + kq1.Xuat();
            Console.WriteLine(chuoi1);*/

            /*//XU LY DIEM
            //B1. Tao lap cac doi tuong can thiet
            Diem x = new Diem();
            Diem y = new Diem();
            //B2. Yeu cau doi tuong thuc hien hanh dong
            x.Nhap("Nhap diem X: ");
            y.Nhap("Nhap diem Y: ");
            double kq2 = x.TinhKhoangCach(y);
            string chuoi2 = "Ket qua la " + kq2;
            Console.WriteLine(chuoi2);*/

            /*//XU LY TAM GIAC 
            //B1. Tao lap cac doi tuong can thiet
            DaGiac tg = new DaGiac();
            //B2. Yeu cau doi tuong thuc hien hanh dong
            tg.Nhap("Nhap thong tin da giac");
            double kq = tg.TinhChuVi();
            Console.WriteLine("Ket qua la " + kq);
            //B3. Xuat ket qua*/

            /*CongTy congTy = new CongTy();
            congTy.Nhap("Nhap thong tin cong ty ");
            Console.WriteLine(congTy.TinhTongLuong());*/

            /*MatPhang a = new MatPhang();
            a.Nhap("Nhap thong tin mat phang: ");
            Console.WriteLine(a.TinhTongChuVi());*/
        }
    }
}
        