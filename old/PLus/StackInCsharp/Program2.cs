using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program2
{
    static void Main1(string[] args)
    {
        Stack MyStack = new Stack();
        for(int i = 1; i <= 3; i++)
        {
            Console.Write($"Chuoi thu {i}: ");
            string s = Console.ReadLine();
            MyStack.Push(s);
        }

        while(MyStack.Count > 0)
        {
            Console.WriteLine(MyStack.Pop());
        }

        Console.WriteLine("so luong chuoi con trong stack: {0}", MyStack.Count);
        if(MyStack.Count == 0)
        {
            Console.WriteLine("Stack rong");
        }
    }
}
