using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        Hashtable hash = new Hashtable();

        hash.Add("K", "Kteam");
        hash.Add("P", "PhucLe");
        hash.Add("D", "Developer");


        Console.WriteLine(hash["P"]);
        Console.WriteLine();

        foreach(DictionaryEntry item in hash)
        {
            Console.WriteLine("Key: " + item.Key + " - Value: " + item.Value);
        }
    }
}