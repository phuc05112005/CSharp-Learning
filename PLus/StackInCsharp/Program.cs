using System.Collections;
class Program
{
    static void Main1(string[] args)
    {
        Stack MyStack = new Stack();

        MyStack.Push("Le");
        MyStack.Push("Hoang");
        MyStack.Push("Phuc");

        Console.WriteLine("So luong phan tu co trong Stack: {0}", MyStack.Count);

        Console.WriteLine("Phan tu dau o trong Stack: {0}", MyStack.Peek());

        Console.WriteLine("Popping...");
            int Length = MyStack.Count;
        for (int i = 0; i < Length; i++)
        {
            Console.Write(" " + MyStack.Pop());
        }
        Console.WriteLine();
        Console.WriteLine("So luong phan tu con trong Stack: {0}", MyStack.Count);
    }
}