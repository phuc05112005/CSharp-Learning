using System.Globalization;

namespace GLLT
{
    internal class Program
    {
        // Truyen tham tri - Khong thay doi gia tri sau khi goi ham
        
        static void ThamTri(int n)
        {
            n += 1;
            Console.Write("\nKet qua khi goi ham: " + n);
        }


        // Truyen tham chieu(ref - Thay doi gia tri sau khi goi ham(can khai bao gia tri cua bien truoc)
        static void ThamChieu(ref int n)
        {
            n++;
            Console.Write("\nKet qua khi goi ham: " + n);
        }

        // Truyen tham chieu(out) - Thay doi gia tri sau khi goi ham(khong can khai bao gia tri cua bien truoc)
        static void ThamChieu2(out int n)
        {
            n = 3;
            Console.Write("\nKet qua khi goi ham: " + n);
        }
        static void Main(string[] args)
        {
            int a = 1;
            Console.Write("\nKet qua truoc khi goi ham: " + a);
            ThamTri(a);
            Console.Write("\nKet qua truoc sau goi ham tham tri: " + a);
            ThamChieu(ref a);
            Console.Write("\nKet qua sau khi goi ham tham chieu(ref): " + a);
            int b;
            ThamChieu2(out b);
            Console.Write("\nKet qua sau khi goi ham tham chieu(out): " + b);

        }
    }
}
