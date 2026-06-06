using LAB01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    public class Tester
    {
        public static void Main()
        {
            SinhVien sv1 = new SinhVien("0123456789", "Le Hoang Phuc", "CNTT", 8);
            sv1.show();

            SinhVien sv2 = new SinhVien("0123456789", "nguyen van a", "QLDD", 6);
            sv2.show();

            Console.WriteLine("======");
            Console.WriteLine("Nhap so luong sinh vien");
            int n = int.Parse(Console.ReadLine());
            SinhVien[] danhSach = new SinhVien[n];

            for (int i = 0; i < danhSach.Length; i++)
            {
                danhSach[i] = new SinhVien();
                danhSach[i].nhapDuLieu();
            }

            Console.WriteLine("======");
            for (int i = 0; i < danhSach.Length; i++)
            {
                danhSach[i].show();
            }
        }
    }
}
