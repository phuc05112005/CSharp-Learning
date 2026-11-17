using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examble.Kethua_Abstract
{
    public class Magazine : Document
    {
        public int Issue {  get; set; }
        public string Month { get; set; }

        public Magazine(int issue, string month, string id, string title, int year) : base(id, title, year) 
        {
            Issue = issue;
            Month = month;
        }

        public override string GetType()
        {
            return "Magazine";
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Issue: {Issue}");
            Console.WriteLine($"Month: {Month}");
            Console.WriteLine($"Type: {GetType()}");
        }

        public virtual void Borrow()
        {
            base.Borrow();
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Quyen sach {Title} dang duoc muon");
            }
            else
            {
                Console.WriteLine($"Quyen sach {Title} dang khong cho ai muon");
            }
        }

        public virtual void Return()
        {
            base.Return();
            if (!IsAvailable)
            {
                IsAvailable = true;
                Console.WriteLine($"Quyen sach {Title} da duoc tra");
            }
            else
            {
                Console.WriteLine($"Quyen sach {Title} chua duoc tra");
            }
        }
    }
}
