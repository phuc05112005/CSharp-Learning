namespace GLLT
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Dictionary<int, string> dic = new() { { 1, "Phuc" }, { 2, "Duc" } };

            // Them phan tu vao dic
            dic.Add( 3, "Nam");

            // Duyet dic
            foreach(KeyValuePair<int, string> x in dic)
            {
                Console.WriteLine(x);
                Console.WriteLine(x.Key );
                Console.WriteLine(x.Value);
                
            }

            // Kiem tra xem key co ton tai trong dic khong
            bool kq = dic.ContainsKey(2);
            Console.WriteLine("Key co ton tai khong dic khong? => " + kq);

            // Kiem tra xem value co ton tai trong dic khong
            bool kq2 = dic.ContainsValue("Phuc");
            Console.WriteLine("Value co ton tai khong dic khong? => " + kq2);

            // Lay value tu key
            string name = dic[3];
            Console.WriteLine(name);

            // gan gia tri moi cho key
            dic[3] = "Huy";
            Console.WriteLine(dic[3]);

            // Xoa phan tu theo key
            dic.Remove(3);
            foreach (KeyValuePair<int, string> x in dic)
            {
                Console.WriteLine(x);

            }

            // Chuyen values dic => list
            Dictionary<int, string> dic2 = new() { { 1, "Phuc" }, { 2, "Duc" } };
            List<string> dsValue = new();
            dsValue = dic2.Values.ToList();
            Console.Write("Danh sach value trong danh sach: ");
            foreach(string x in dsValue)
            {
                Console.Write(x + " ");
            }

            // Chuyen key dic => list
            List<int> dsKey = new();
            dsKey = dic2.Keys.ToList();
            Console.Write("\nDanh sach key trong danh sach: ");
            foreach(int x in dsKey)
            {
                Console.Write(x + " ");
            }


            Console.Read();
        }
    }
}
