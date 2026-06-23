// BMI = Can nang/ Chieu Cao^2

using System;
using System.Runtime.Intrinsics.X86;

class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        double canNang = 0;
        double chieuCao = 0;

        Console.Write("Nhập cân nặng (kg): ");
        canNang = double.Parse(Console.ReadLine());

        Console.Write("Nhập chiều cao (m): ");
        chieuCao = double.Parse(Console.ReadLine());
        
        double bmi = canNang /(chieuCao*chieuCao);

        Console.WriteLine("BMI cua ban la: {0}", bmi);

        Console.WriteLine("Nhấn phím bất kỳ để thoát!");
        Console.ReadKey();
    }
}