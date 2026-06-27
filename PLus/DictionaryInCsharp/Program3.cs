using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInCsharp
{
    class Program3
    {
        static void Main1(string[] args)
        {
            Dictionary<int, Student> student = new Dictionary<int, Student>();
            student.Add(1, new Student { Id = 111, Name = "Phuc" });
            student.Add(2, new Student { Id = 222, Name = "Duc" });
            student.Add(3, new Student { Id = 333, Name = "An" });
            student.Add(4, new Student { Id = 444, Name = "Binh" });
            student.Add(5, new Student { Id = 555, Name = "Nam" });

            foreach (KeyValuePair<int, Student> s in student)
            {
                Console.WriteLine(s.Key + " / " + s.Value.Id +"-" + s.Value.Name);
            }

            Console.Write("Nhap Id sinh vien can tim: ");
            int id = int.Parse(Console.ReadLine());
            if (student.ContainsKey(id))
            {
                Console.WriteLine(student[id].Id +"-"+ student[id].Name);
            }
            else
            {
                Console.WriteLine("khong co sinh vien can tim");
            }

        }

        class Student
        {
            public int Id;
            public string Name;
        }
    }
}
