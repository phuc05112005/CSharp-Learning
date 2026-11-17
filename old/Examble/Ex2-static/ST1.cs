using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex2_static
{
    public class ST1
    {
        // static field
        public static int TotalStudent = 0;

        // Instance field

        private string name;

        public string Name
        {
            get
            {
                return StringUtils.toTitleCase(name);
            }
            set
            {
                name = value;
            }
        }


        public ST1(string name)
        {
            this.Name = name;
            TotalStudent++;
        }
    }

    class Program
    {
        public static void Main2()
        {
            Console.WriteLine($"Ban dau co: {ST1.TotalStudent} sinh vien");
            ST1 st1 = new ST1("nguyen van a");
            Console.WriteLine(st1.Name);
            Console.WriteLine($"Sau do co : {ST1.TotalStudent} sinh vien");
        }
    }
}