using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.Bai13_Datetime
{
    internal class Program
    {
        static void Main1()
        {
            DateTime dt = new DateTime(2005, 11, 05);
            Console.WriteLine("Ngay sinh cua toi la: {0}", dt.ToString("dd/MM/yyyy"));
            Console.WriteLine("Nam sinh cua toi la: {0}", dt.ToString("yyyy"));

            DateTime dt2 = DateTime.Parse("11/14/2005");
            Console.WriteLine("Ngay sinh cua ban: {0}", dt2.ToString("dd"));
            Console.WriteLine("Thang sinh cua ban: {0}", dt2.ToString("MM"));
            Console.WriteLine("Nam sinh cua ban: {0}", dt2.ToString("yyyy"));


            Console.Write("Nhap ngay thang nam sinh (mm/dd/yyyy): ");
            string s = Console.ReadLine();
            DateTime dt3 = DateTime.Parse(s);
            Console.WriteLine("Ngay sinh cua ban: {0}", dt3.ToString("dd"));
            Console.WriteLine("Thang sinh cua ban: {0}", dt3.ToString("MM"));
            Console.WriteLine("Nam sinh cua ban: {0}", dt3.ToString("yyyy"));
            Console.ReadKey();
        }
    }
}
