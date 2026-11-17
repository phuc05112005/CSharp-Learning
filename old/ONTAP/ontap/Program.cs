namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hoTen;
            float diemToan;
            float diemVan;

            Console.WriteLine("Nhap ho ten: ");
            hoTen = Console.ReadLine();

            Console.WriteLine("Nhap dien toan: ");
            diemToan = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap diem van: ");
            diemVan = float.Parse(Console.ReadLine());

            Console.WriteLine("Hoc sinh ten " + hoTen + " co diem toan la " + diemToan + ", diem van la " + diemVan);
            Console.ReadKey();
        }
    }
}