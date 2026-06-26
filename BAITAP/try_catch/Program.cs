using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.try_catch
{
    internal class Program
    {
        public static void ngoaile()
        {
            Console.Write("Nhap vao tu so: ");
            int tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao mau so: ");
            int mau = int.Parse(Console.ReadLine());

            if (mau == 0)
                throw new ArgumentException("Loi mau so bang 0!!!");
        }

        public static void Main1(string[] args)
        {
            try
            {
                ngoaile();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
