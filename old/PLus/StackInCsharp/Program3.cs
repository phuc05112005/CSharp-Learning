    using System;
    using System.Collections;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program3
    {
        static void Main(string[] args)
        {
            string s = "abc123xyz";
            Stack MyStack = new Stack();

            foreach(char c in s)
            {
                if (char.IsLetter(c))
                {
                    MyStack.Push(c);
                    Console.WriteLine(c);
                }
            }

            string result = "";
            foreach(char c in s)
            {
                if(char.IsLetter(c))
                {
                    result += MyStack.Pop();
                }
                else
                {
                    result += c;
                }

            }
        Console.WriteLine("Chuoi goc: " + s);
        Console.WriteLine("Ket qua : " + result);
    }
    }