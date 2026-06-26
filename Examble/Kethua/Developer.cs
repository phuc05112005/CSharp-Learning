using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examble.BAITAP1
{
    public class Developer : Employee
    {
       private string programmingLanguage;
       private int projectCount;

        public Developer() : base()
        {
            this.ProgrammingLanguage = "No Programming Language";
            this.ProjectCount = 0;
        }
        public Developer(int id, string name, double baseSalary, string department, string programingLanguage, int projectCount) : base(id, name, baseSalary, department)
        {
            this.ProgrammingLanguage = programingLanguage;
            this.ProjectCount = projectCount;
        }

        public string ProgrammingLanguage
        {
            get { return programmingLanguage; }
            set { programmingLanguage = value; }
        }
        public int ProjectCount
        {
            get { return projectCount; }
            set { projectCount = value; }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Programming Language: {programmingLanguage}");
            Console.WriteLine($"Project Count: {projectCount}");
        }
        public override double CalculateSalary()
        {
            return BaseSalary + (ProjectCount + 1000);
        }
        public void WriteCode()
        {
            Console.WriteLine($"{Name} dang viet code bang {ProgrammingLanguage}");
        }
        public override void WorkDaily()
        {
            base.WorkDaily();
        }
    }
}