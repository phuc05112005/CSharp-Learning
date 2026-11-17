namespace Part4SapXep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var mang = new int[10];
            
            for (int k = 0; k < mang.Length; k++)
            {
                mang[k] = rand.Next(1, 100);
            }

            foreach (int x in mang)
            {
                Console.Write(x + " ");
            }

            // sap xep
            for(int i = 0; i<mang.Length - 1; i++)
            {
                for (int j = mang.Length - 1; j > i; j--)
                {
                    if (mang[i] > mang[j])
                    {
                        int temp = mang[i];
                        mang[i] = mang[j];
                        mang[j] = temp;
                    }
                }
            }

            Console.WriteLine();
            foreach (int x in mang)
            {
                Console.Write(x + " ");
            }
        }
    }
}
