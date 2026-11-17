using System.Collections;

class Program
{
    static void Main1(string[] args)
    {
        Dictionary<int, string> Sv = new Dictionary<int, string>();

        Sv.Add(1, "Phuc");
        Sv.Add(2, "Duc");

        foreach(KeyValuePair<int, string> s in Sv)
        {
            Console.WriteLine("Key: " + s.Key + ", Value: " + s.Value);
        }
    }
}