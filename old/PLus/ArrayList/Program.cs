using System.Collections;
namespace ArrayListInCsharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrPersons = new ArrayList();

            arrPersons.Add(new Person("Le Hoang Phuc", 20));
            arrPersons.Add(new Person("Nguyen Van An", 26));
            arrPersons.Add(new Person("Tran Thi Be", 18));
            arrPersons.Add(new Person("Vo Hoang Nam", 34));
            arrPersons.Add(new Person("Le Hong Duc", 22));

            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();

            arrPersons.Sort(new SortPerson());

            Console.WriteLine("Danh sach sau khi sap xep tuoi tang dan: ");
            foreach (Person item in arrPersons)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


            //ArrayList MyArray = new ArrayList();
            //ArrayList MyArray2 = new ArrayList(5);
            //ArrayList MyArray3 = new ArrayList(MyArray2);
            //ArrayList MyArray4 = MyArray2;
                
            //Console.WriteLine($"Capacity: {MyArray.Capacity}");
            //Console.WriteLine($"Capacity: {MyArray2.Capacity}");
            //Console.WriteLine($"Capacity: {MyArray3.Capacity}");
            //Console.WriteLine($"Capacity: {MyArray4.Capacity}");


        }
    }

    public class SortPerson : IComparer
    {
        public int Compare(object x, object y)
        {
            Person p1 = x as Person;
            Person p2 = y as Person;

            if(p1 == null || p2 == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                if(p1.Age > p2.Age)
                {
                    return 1;
                }
                else if(p1.Age ==  p2.Age)
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