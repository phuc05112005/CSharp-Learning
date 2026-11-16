using System.Runtime.Intrinsics.Arm;

namespace TITV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <=10)
            {
                Console.Write(i + " ");
                i++;
            }

            Console.WriteLine();
            for(int j = 1; j <= 10; j++)
            {
                Console.Write(j + " ");
            }

            Console.WriteLine();
            for (int k = 1; k <= 10; k++,Console.Write(k + " "));

            Console.WriteLine();
            int[] a = new int[5] { 2, 4, 6, 8, 10 };
            foreach(int x in a)
            {
                Console.Write(x + " ");
            }


            Console.WriteLine();
            int[] arr = [2, 5, 6, 7, 8, 4, 3, 1, 5, 7, 2];
            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write(arr[z] + " ");
            }

            Console.WriteLine();
            foreach (int y in arr)
            {
                Console.Write(y + " ");
            }

            Console.WriteLine();    
            for (int z = 0; z < arr.Length; z++)
            {
                arr[z] = 1;
            }

            Console.WriteLine();
            foreach (int y in arr)
            {
                Console.Write(y + " ");
            }
        }
    }
}
