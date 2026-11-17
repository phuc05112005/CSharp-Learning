using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program1
{
    static void Main1(string[] args)
    {
        Stack MyStack = new Stack();

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Nhap so thu {i}: ");
            MyStack.Push(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("So luong phan tu trong stack: {0}", MyStack.Count);

        Console.WriteLine("Phan tu dau tien trong stack: {0}", MyStack.Peek());

        int length = MyStack.Count;
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(MyStack.Pop());
        }

        Console.WriteLine("So luong phan tu con lai trong stack: {0}", MyStack.Count);

    }
}