using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examble.Kethua_Abstract
{
    public class Book : Document
    {
        public string Author { get; set; }
        public string PublishingHouse { get; set; }
        public int Pages { get; set; }

        public Book(string author, string publishingHouse, int pages, string id, string title, int year) 
            : base(id, title, year) 
        {
            Author = author;
            PublishingHouse = publishingHouse;
            Pages = pages;
        }
        public override string GetType()
        {
            return "Book";    
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publishing: {PublishingHouse}");
            Console.WriteLine($"Page: {Pages}");
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
