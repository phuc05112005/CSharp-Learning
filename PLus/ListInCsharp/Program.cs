using System.Collections.Generic;

class Program
{
    static void Main1(string[] args)
    {
        List<string> MyList = new List<string>();

        MyList.Add("Hoang");
        MyList.Add("Phuc");

        Console.WriteLine("Chuoi ban dau: ");
        Console.WriteLine("So luong chuoi trong list: {0}", MyList.Count);
        foreach(string item in MyList)
        {
            Console.WriteLine(item + " ");
        }

        MyList.Insert(0, "Le");
        Console.WriteLine("Chuoi sau khi them: ");
        foreach(string item in MyList)
        {
            Console.WriteLine(item + " ");
        }
        Console.WriteLine("So luong chuoi trong list : {0}", MyList.Count);

        bool CheckMyList = MyList.Contains("Phuc");

        if (!CheckMyList)
        {
            Console.WriteLine("Khong");
        }
        else
        {
            Console.WriteLine("Co");
        }
    }
}