using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examble.BAITAP1
{
    public class Manager : Employee
    {
        private double bonus;
        private int teamSize;

        public Manager() : base()
        {
            this.Bonus = 0;
            this.TeamSize = 0;
        }
        public Manager(int id, string name, double baseSalary, string department, double bonus, int teamSize) : base(id, name, baseSalary, department)
        {
            this.Bonus = bonus;
            this.TeamSize = teamSize;
        }

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public int TeamSize
        {
            get { return teamSize; }
            set { teamSize = value; }
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: {Bonus}");
            Console.WriteLine($"Teamsize: {TeamSize}");
        }
        public override double CalculateSalary()
        {
            return BaseSalary + Bonus + (TeamSize * 1000);
        }
        public void ManagerTeam()
        {
            Console.WriteLine($"{Name} co {TeamSize} thanh vien");
        }
    }
}


