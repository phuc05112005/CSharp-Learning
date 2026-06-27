using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInCsharp
{
    class Program1
    {
        static void Main1(string[] args)
        {
            List<string> StudentName = new List<string>();

            int n;
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Nhap sinh vien {i}: ");
                StudentName.Add(Console.ReadLine());
            }

            Console.WriteLine("So luong sinh vien dang co: {0}", StudentName.Count);
            foreach(string s in StudentName)
            {
                Console.WriteLine(s);
            }

            StudentName.Remove("Phuc");

            string Search = "Duc";
            if (StudentName.Contains(Search))
            {
                Console.WriteLine("Tim thay: " + Search);
            }
            else
            {
                Console.WriteLine("Khong tim thay: " + Search);
            }
        }
    }
}
