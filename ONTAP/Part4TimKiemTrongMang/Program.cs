namespace Part4TimKiemTrongMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int i;
            int[] mang = new int[10];

            for(i = 0; i < mang.Length; i++)
            {
                mang[i] = rand.Next(1, 100);
            }

            foreach(int x in mang)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            Console.Write("Nhap so can tim: ");
            int num = int.Parse(Console.ReadLine());

            i = 0;
            while(i < mang.Length && mang[i] != num)
            {
                i++;
            }

            if(i == mang.Length)
            {
                Console.WriteLine("So {0} khong co trong mang", num);
            }
            else
            {
                Console.WriteLine("So {0} nam o vi tri {1}", num, i);
            }
        }
    }
}
