namespace TITV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int rows = 4;
            const int cols = 3;

            int[,] r = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j<cols; j++)
                {
                    r[i, j] = i + j;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(r[i,j] + " ");
                }
                Console.WriteLine();
            }


            //
            Console.WriteLine();
            int[][] b = new int[rows][];
            b[0] = new int[2];
            b[1] = new int[3];
            b[2] = new int[4];
            b[3] = new int[5];

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < b[i].Length; j++)
                {
                    b[i][j] = i + j;
                    Console.Write(b[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
