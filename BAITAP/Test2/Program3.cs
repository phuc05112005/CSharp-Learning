// IF ELSE
using System;

class Program3
{
    public static void Main3()
    {
        double a, b;
        Console.WriteLine("Giai phuong trinh  bac nhat ax + b = 0");

        Console.Write("Nhap he so a: ");
        a = double.Parse(Console.ReadLine());

        Console.Write("Nhap he so b: ");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Phuong trinh {0}x + {1} = 0", a, b);

        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
            else
            {
                Console.WriteLine("Phuong trinh vo nghiem!");
            }
        }
        else
        {
            double x = -b / a;
            Console.WriteLine("Nghiem cua phuong trinh: x = {0}", x);
        }

        Console.WriteLine("Nhan phim bat ky de thoat");
        Console.ReadKey();
    }
}
