using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInCsharp
{
    class Program4
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> account = new Dictionary<string, string>();

            account.Add("phuc", "1234");
            account.Add("admin", "123");

            while (true)
            {
                Console.WriteLine("---MENU---");
                Console.WriteLine("1- Dang ky");
                Console.WriteLine("2 - Dang nhap");
                Console.WriteLine("3 - Doi mat khau");
                Console.WriteLine("4 - Hien thi danh sach tai khoan");

                Console.Write("Chon: ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        {
                            Console.Write("Nhap username: ");
                            string username = Console.ReadLine();
                            if (account.ContainsKey(username))
                            {
                                Console.WriteLine("Tai khoan da ton tai");
                            }
                            else
                            {
                                Console.Write("Nhap mat khau: ");
                                string password = Console.ReadLine();

                                account.Add(username, password);
                                Console.WriteLine("Dang ky thanh cong!");
                            }
                                break;
                        }
                    case 2:
                        {
                            Console.Write("Nhap username:");
                            string username = Console.ReadLine();
                            if(account.ContainsKey(username))
                            {
                                Console.Write("Nhap password: ");
                                string password = Console.ReadLine();
                                if (account[username] == password)
                                {
                                    Console.WriteLine("Dang nhap thanh cong!");
                                }
                                else
                                {
                                    Console.WriteLine("Sai mat khau");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Username chua tao tai khoan");
                            }
                                break;
                        }
                    case 3:
                        {
                            Console.Write("Nhap username: ");
                            string username = Console.ReadLine();
                            if (account.ContainsKey(username))
                            {
                                Console.Write("Nhap mat khau cu: ");
                                string oldpassword = Console.ReadLine();
                                if (account[username] == oldpassword)
                                {
                                    Console.Write("Nhap mat khau moi: ");
                                    string newpassword = Console.ReadLine();

                                    account[username] = newpassword;
                                    Console.WriteLine("Doi mat khau thanh cong!");
                                }
                                else
                                {
                                    Console.WriteLine("Nhap mat khau cu sai");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Username khong ton tai");
                            }
                                break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Danh sach tai khoan tren he thong:");
                            foreach(KeyValuePair<string, string> s in account)
                            {
                                Console.WriteLine("username: " + s.Key + " - password: " + s.Value);
                            }
                            break;
                        }
                }
            }
        }
    }
}
