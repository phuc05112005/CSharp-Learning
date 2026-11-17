namespace Part4CTDK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            var list = new List<string>();
            foreach (string arg in args)
            {
                list.Add(arg.ToUpper());
            }

            foreach(string arg in list)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
