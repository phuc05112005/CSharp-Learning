using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    internal class Test
    {
        static void Main(string[] args)
        {
            HocSinh hs1 = new HocSinh();
            hs1.HienThiThongTin();

            HocSinh hs2 = new HocSinh("Tran Thi B", 17, 9.0);
            hs2.HienThiThongTin();

            HocSinh hs3 = new HocSinh("Le Van C", 19);
            hs3.HienThiThongTin();

            hs3.DiemTB = -1;
            hs3.HienThiThongTin();

            hs3.DiemTB = 7.5;
            hs3.HienThiThongTin();
            Console.Read();
        }
    }
}
