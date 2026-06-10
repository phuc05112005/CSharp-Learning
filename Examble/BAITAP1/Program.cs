using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examble.BAITAP1
{
    public class Program
    {
        public static void Main()
        {
            Manager nv1 = new Manager(001, "le hoang phuc", 2000, "BE Java", 200, 3);
            nv1.DisplayInfo();
            Console.WriteLine($"Tong luong: {nv1.CalculateSalary()}");
            nv1.WorkDaily();

            Developer nv2 = new Developer(002, "nguyen van a", 800, "BE Java", "Java", 20);
            nv2.DisplayInfo();
            nv2.WorkDaily();
            Console.WriteLine($"Tong luong: {nv2.CalculateSalary()}");


            Tester nv3 = new Tester(003, "Nguyen THI B", 500, "Testing", "Selenium",50);
            nv3.DisplayInfo(); 
            nv3.WorkDaily();
            Console.WriteLine($"Tong luong: {nv3.CalculateSalary()}");


            // Tinh da hinh
            Employee nv4 = new Manager(001, "le hoang phuc", 2000, "BE Java", 200, 3);
            Employee nv5 = new Developer(002, "nguyen van a", 800, "BE Java", "Java", 20);
            Employee nv6 = new Tester(003, "Nguyen THI B", 500, "Testing", "Selenium", 50);

            Employee[] arr = new Employee[] { nv4, nv5, nv6 };

        }
    }
}
