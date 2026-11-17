using System;
using System.Collections.Generic;
using System.Text;

namespace GLLT
{
    internal class Bai29
    {
        static void Main1(string[] args)
        {
            string username = "";
            string password = "";
            Dictionary<string, string> dic = new();
            dic.Add("user1", "123456");
            dic.Add("user2", "123456");
            dic.Add("user3", "123456");
            dic.Add("user4", "123456");
            dic.Add("user5", "123456");

            Console.Write("Nhap ussername: ");
            username = Console.ReadLine();
            Console.Write("Nhap password: ");
            password = Console.ReadLine();

            if (dic.ContainsKey(username))
            {
                if (dic.ContainsValue(password))
                {
                    Console.WriteLine("Dang nhap thanh cong");
                } else
                {
                    Console.WriteLine("PASSWORD SAI");
                }
                
            } else
            {
                Console.WriteLine("Username khong ton tai");
            }
        }
    }
}
