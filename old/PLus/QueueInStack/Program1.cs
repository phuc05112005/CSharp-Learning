using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program1
{
    static void Main(string[] args)
    {
        Queue MyQueue = new Queue();

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"Nhap phan tu thu {i}: ");
            MyQueue.Enqueue(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("So luong phan tu trong Queue: {0}", MyQueue.Count);
        Console.WriteLine("Phan tu dau tien trong Queue: {0}", MyQueue.Peek());
        
        int length = MyQueue.Count;
        for(int i = 0; i < length; i++)
        {
            Console.WriteLine(MyQueue.Dequeue());
        }
        Console.WriteLine();
        Console.WriteLine("So luong phan tu con lai trong Queue: {0}", MyQueue.Count);

    }
}
