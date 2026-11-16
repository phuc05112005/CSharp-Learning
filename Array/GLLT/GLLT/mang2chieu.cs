using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLLT
{
    internal class mang2chieu
    {
        public static void Main(string[] args)
        {
            const int rows = 3;
            const int cols = 4;
            Random rand = new Random();
            int[,] arr = new int[rows, cols];

            // In vi tri cac phan tu trong mang
            for (int i = 0; i<rows; i++)
            {
                for(int j = 0; j<cols; j++)
                {
                    Console.Write(i);
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            
            Console.WriteLine();
            for(int i = 0; i<rows; i++)
            {
                for(int j = 0; j<cols; j++){
                    arr[i, j] = rand.Next(10);
                }
            }

            // In gia tri cac phan tu trong mang 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

            // // In gia tri cac phan tu trong mang - Dung GetLength
            Console.WriteLine();
            for(int i = 0; i<arr.GetLength(0); i++)
            {
                for(int j = 0; j <arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j] + " ");
                    
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
