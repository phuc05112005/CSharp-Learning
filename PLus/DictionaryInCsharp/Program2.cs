using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInCsharp
{
    public class Program2
    {
        static void Main1(string[] args)
        {
            Dictionary<int, string> Staff = new Dictionary<int, string>();

            Staff.Add(1, "An");
            Staff.Add(2, "Binh");
            Staff.Add(3, "Phuc");

            Console.WriteLine("Danh sach NV:");
            foreach(KeyValuePair<int, string> s in Staff)
            {
                Console.WriteLine(s.Key + " - " + s.Value);
            }

            Staff[1] = "Anh";

            Console.WriteLine("Danh sach NV moi:");
            foreach (KeyValuePair<int, string> s in Staff)
            {
                Console.WriteLine(s.Key + " - " + s.Value);
            }
        }


    }
}
