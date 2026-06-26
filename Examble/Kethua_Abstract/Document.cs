using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examble.Kethua_Abstract 
{ 
    public abstract class Document
    {
        //Properties
        public string Id { get; protected set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; protected set; }

        // Constructor
        public Document(string id, string title, int year)
        {
            Id = id;
            Title = title;
            Year = year;
            IsAvailable = true;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Title:  {Title}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Status: {(IsAvailable ? "Available" : "Borrowed")}");
        }

        public abstract string GetType();

        public virtual void Borrow()
        {
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