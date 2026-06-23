using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "abcdefghijklmnopqrstuvwxyz";
            string b = "zxcvbnmasdfghjklqwertyuiop";
            
            Console.Write("Nhap vao chuoi ky tu: ");
            string chuoiinput = Console.ReadLine();

            string ghepChuoi = "";
            foreach (char c in chuoiinput)
            {
                int indexKytu = a.IndexOf(c);
                ghepChuoi += b[indexKytu];
            }
            Console.WriteLine(ghepChuoi);
            Console.ReadKey();
        }
    }
}
