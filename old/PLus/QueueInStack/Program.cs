using System.Collections;
class Program
{
    static void Main1(string[] args)
    {
        Queue MyQueue = new Queue();

        MyQueue.Enqueue("Le");
        MyQueue.Enqueue("Hoang");
        MyQueue.Enqueue("Phuc");

        Console.WriteLine("Phan tu dau tien trong Queue la: {0}", MyQueue.Peek());
        Console.WriteLine("So luong: {0}", MyQueue.Count);

        Console.WriteLine("Popping...");
        int length = MyQueue.Count; 
        for(int i = 0; i < length; i++)
        {
            Console.Write(MyQueue.Dequeue() + " ");
        }
        Console.WriteLine();
        Console.WriteLine("So luong: {0}", MyQueue.Count);
    }
}