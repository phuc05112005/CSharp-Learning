using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examble.BAITAP1
{
    public class Tester : Employee
    {
        private string testingTool;
        private int bugFound;

        public Tester() : base()
        {
            this.TestingTool = string.Empty;
            this.BugFound = 0;
        }
        public Tester(int id, string name, double baseSalary, string department, string testingtool, int bugFound) : base(id, name, baseSalary, department)
        {
            this.TestingTool = testingtool;
            this.BugFound = bugFound;
        }
        public string TestingTool
        {
            get { return testingTool; } 
            set { testingTool = value; }
        }
        public int BugFound
        {
            get { return bugFound; } 
            set { bugFound = value; }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Cong cu: {TestingTool}");
            Console.WriteLine($"Loi: {BugFound}");
        }
        public override double CalculateSalary()
        {
            return BaseSalary + (BugFound + 500);
        }
        public override void WorkDaily()
        {
            base.WorkDaily();
        }
        public void ToolTest()
        {
            Console.WriteLine($"{Name} dang dung co cu {TestingTool}");
        }
    }
}
