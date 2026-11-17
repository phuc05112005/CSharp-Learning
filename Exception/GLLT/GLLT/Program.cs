namespace GLLT
{
    internal class Program
    {
        static void NgoaiLe()
        {
            Console.Write("Nhap tu so: ");
            int tu = int.Parse(Console.ReadLine());
            Console.Write("Nhap mau so: ");
            int mau = int.Parse(Console.ReadLine());
            if (mau == 0)
                throw new ArithmeticException("Mau bang 0 roi");
            else
                Console.Write("\nKet qua: " + tu +"/" + mau);
        }
        static void Main(string[] args)
        {
            try
            {
                NgoaiLe();
            } catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
