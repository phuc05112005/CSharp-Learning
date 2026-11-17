namespace Part3Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            f();
            f1();
            f2();
        }

        static void f()
        {
            int[] mang = [2, 4, 6, 8, 10];
            for(int i = 0; i < mang.Length; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
        }
        

        static void f1()
        {
            int[,,] mang3chieu =
            {
                {
                   {1,2,3,4,5,6 },
                   {2,3,4,5,6,7 }
                }
            };
            Console.WriteLine(mang3chieu[0,0,2]);
        }

       
        static void f2()
        {
            int[][] mm = new int[2][];

            mm[1] = new int[2];
            mm[1][0] = 1;
            Console.WriteLine(mm);
        }
    }
}
