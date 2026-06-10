using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examble.BAITAP1
{
    public class Employee
    {
        private int id;
        private string name;
        private double baseSalary;
        private string deparment;

        public Employee()
        {
            this.Id = 0;
            this.Name = "No Name";
            this.BaseSalary = 0;
            this.Department = "No Deparment";
        }
        public Employee(int id, string name, double baseSalary, string department)
        {
            this.Id = id;
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.Department = department;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return ToTitleCase(name); }
            set { name = value; }
        }
        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }
        public string Department
        {
            get { return deparment; }
            set { deparment = value; }
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Base Salary: {baseSalary}");
            Console.WriteLine($"Department: {Department}");
        }

        public virtual double CalculateSalary()
        {
            return baseSalary;
        }

        public virtual void WorkDaily()
        {
            Console.WriteLine($"{Name} - Lam viec luc 9:00 AM");
        }

        public virtual string ToTitleCase(string text)
        {
            string result = "";
            string[] words = text.Split(' ');

            foreach( string word in words) {
                string KyTuDau = "";
                string CacTuConLai = "";

                if( word.Length >= 1 ) 
                    KyTuDau = word.Substring(0, 1).ToUpper();
                if (word.Length >= 2)
                    CacTuConLai = word.Substring(1).ToLower();
                result += KyTuDau + CacTuConLai + " ";
            }
            return result.Trim();
        }
    }
}