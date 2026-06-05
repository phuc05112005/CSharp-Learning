using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program6
{
   public static void Main6()
    {
        // A. Kich thuoc cach hang giong nhau
        // Khai bao mang 2 chieu
        // kieudulieu[,] tenMang;
        const int rows = 4;
        const int columns = 3;

        int[,] r = new int[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                r[i, j] = i + j;
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                r[i, j] = i + j;
                Console.Write(r[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("=================");


        // B. Kinh thuoc cot trong hang khac nhau
        int[][] b = new int[rows][];

        b[0] = new int[2];
        b[1] = new int[3];
        b[2] = new int[4];
        b[3] = new int[5];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < b[i].Length; j++)
            {
                b[i][j] = i + j;
                Console.Write(b[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
