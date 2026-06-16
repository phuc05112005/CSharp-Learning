using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAP.string20
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1.Nhap mat khau it nhat 6 ki tu, it nhat co 1 chu cai va 1 chu so
            Console.Write("Nhap mat khau (it nhat 6 ki tu, it nhat co 1 chu cai va 1 chu so): ");
            string mk = Console.ReadLine();
            bool check = true;
            

            while(check)
            {
                int demSo = 0, demChu = 0;
                foreach (char x in mk)
                {
                    if (char.IsDigit(x))
                    {
                        demSo++;    
                    }
                    else if (char.IsLetter(x))
                    {
                        demChu++;
                    }
                }
                if (demSo*demChu != 0 && mk.Length>=6)
                {
                    Console.WriteLine("Dang nhap thanh cong");
                    check = false;
                }
                else
                {
                    Console.Write("Nhap lai mat khau(it nhat 6 ki tu, it nhat co 1 chu cai va 1 chu so): ");
                    mk = Console.ReadLine();    
                    check = true;
                }
            }


            // 2. Nhap mat khau de dang nhap, nhap qua 5 lan thi khoa
            string mk2;
            Console.Write("Nhap mat khau dang nhap: ");
            mk2 = Console.ReadLine();
            int demLogin = 0;


            while (true)
            {
                bool check2 = mk.Equals(mk2);
                if (check2)
                {
                    Console.WriteLine("Dang nhap thanh cong");
                    break;
                }
                else
                {
                    demLogin++;
                    if (demLogin <= 5)
                    {
                        Console.Write("Sai mat khau {0}/5 lan, vui long nhap lai: ", demLogin);
                        mk2 = Console.ReadLine();
                    }
                    else
                    {
                        Console.Write("Ban da nhap sai qua 5 lan,tai khoan bi khoa!");
                        break;

                    }
                }
            }
            Console.ReadLine();
        }
    }
}
