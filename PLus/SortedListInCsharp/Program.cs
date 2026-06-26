using System.Collections;
class Program
{
    static void Main(string[] args)
    {
        SortedList MySL = new SortedList(new PersonComparer());

        MySL.Add(new Person("Phuc", 20),"Le Hoang Phuc");
        MySL.Add(new Person("An", 23), "Nguyen Van An");

        foreach (DictionaryEntry item in MySL)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
        Console.WriteLine();

        SortedList MySL2 = new SortedList();
        MySL2.Add("Phuc","Le Hoang Phuc");
        MySL2.Add("An","Nguyen Van An");
        foreach (DictionaryEntry item in MySL2)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }

    public class PersonComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Person a = x as Person; 
            Person b = y as Person;

            if(a == null || b == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if(a.Age > b.Age)
                {
                    return 1;
                }
                else if(a.Age == b.Age)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
        }
    }
}