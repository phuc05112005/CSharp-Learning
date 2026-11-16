namespace GLLT
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            List<string> ds1 = new List<string> ();
            List<int> ds2 = new List<int>() { 4, 7, 12, 7, 21 };
            List<int> ds3 = new List<int>() { 6, 4 };
            
            foreach(int x in ds2)
            {
                Console.Write(x + " ");
            }

            // Them phan tu vao cuoi danh sach 
            ds2.Add(14);
            Console.Write("\nDanh sach cac phan tu sau khi them: ");
            foreach (int x in ds2)
            {
                Console.Write(x + " ");
            }

            // Xoa phan tu dau tien tim thay trong danh sach 
            ds2.Remove(7);
            Console.Write("\nDanh sach cac phan tu sau khi xoa: ");
            foreach (int x in ds2)
            {
                Console.Write(x + " ");
            }

            // Dem so phan tu trong danh sach 
            Console.WriteLine("\nSo luong phan tu trong danh sach: " + ds2.Count());

            // Xoa toan bo phan tu trong danh sach
            ds2.Clear();
            foreach(int x in ds2)
            {
                Console.Write(x + " ");
            }

            // Chen danh sach khac vao cuoi danh sach hien tai 
            ds2.AddRange(ds3);
            Console.Write("Danh sach sau khi duoc chen them vao cuoi tu danh sach khac: ");
            foreach(int x in ds2)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine("======");
            // Kiem tra xem gia tri co ton tai trong danh sach khong 
            List<int> ds4 = new List<int> { 1, 68, 2, 7, 1, 6, 7, 1, 5, 2, 4 };
            foreach (int x in ds4)
            {
                Console.Write(x + " ");
            }
            Console.Write("\nNhap gia tri can kiem tra: ");
            int num = int.Parse(Console.ReadLine());
            bool kq = ds4.Contains(num);
            Console.WriteLine("Gia tri {0} co trong danh sach? => " + kq, num);


            // Tra ve list con duoc sao chep, lay tu index, va count ky tu cua list cha 
            List<int> ds5 = ds4.GetRange(3,4);
            Console.Write("\nDanh sach cac phan tu duoc lay: ");
            for(int i = 0; i<ds5.Count;i++)
            {
                Console.Write(ds5[i] + " ");
            }

            // In ra vi tri index cua phan tu trong danh sach 
            Console.WriteLine();
            List<int> ds6 = new() { 7, 3, 8, 2, 5, 4, 9, 1 };
            int checkIndex = ds6.IndexOf(4);
            if(checkIndex == -1)
            {
                Console.WriteLine("Phan tu khong co trong danh sach");
            } else
            {
                Console.WriteLine("Vi tri cua phan tu nam o vi tri {0} trong danh sach", checkIndex);
            }

            // Chen them phan tu vao vi tri index 
            ds6.Insert(2, 100);
            Console.Write("Danh sach cac phan tu sau khi chen them gia tri: ");
            foreach(int x in ds6)
            {
                Console.Write(x + " ");
            }

            // Chen danh sach khac them vao vi tri index cua danh sach hien tai
            List<int> ds7 = new() { 200, 300 };
            Console.Write("\nDanh sach cac phan tu sau khi chen them danh sach khac vao vi tri index: ");
            ds6.InsertRange(3,ds7);
            foreach(int x in ds6)
            {
                Console.Write(x + " ");
            }

            // Xoa phan tu trong danh sach tai vi tri index
            ds6.RemoveAt(1);
            Console.Write("Danh sach cac phan tu sau khi xoa phan tu o vi tri index: ");
            foreach(int x in ds6)
            {
                Console.Write(x + " ");
            }

            // Xoa danh sach cac phan tu tu vi tri index, count so phan tu xoa
            ds6.RemoveRange(4, 5);
            Console.Write("\nDanh sach cac phan tu sau khi xoa: ");
            foreach(int x in ds6)
            {
                Console.Write(x + " ");
            }

            // Dao nguoc danh sach
            ds6.Reverse();
            Console.Write("\nDanh sach sau khi dao nguoc: ");
            foreach(int x in ds6)
            {
                Console.Write(x + " ");
            }

            // Sap xep danh sach tang dan
            ds6.Sort();
            Console.Write("\nDanh sach sau khi sap xep tang dan: ");
            foreach (int x in ds6)
            {
                Console.Write(x + " ");
            }

            // Tim kiem nhi phan, tra ve vi tri index cua phan tu can tim, dung sau khi sap xep mang
            int kq1 = ds6.BinarySearch(200);
            Console.Write("\nGia tri can tim nam o vi tri thu " + kq1 + " trong danh sach");


            // Gia tri lon nhat va nho nhat trong danh sach
            Console.WriteLine("\nPhan tu lon nhat trong danh sach la: " + ds6.Max());
            Console.WriteLine("Phan tu nho nhat trong danh sach la: " + ds6.Min());


            Console.Read();        
        }
    }
}
