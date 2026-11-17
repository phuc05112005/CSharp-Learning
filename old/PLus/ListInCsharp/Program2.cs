using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListInCsharp
{
    public class Program2
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(6);
            numbers.Add(9);
            numbers.Add(3);
            numbers.Add(1);

            int Tong = 0;
            int Min = numbers[0];
            int Max = numbers[0];

            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }

            foreach (int x in numbers)
            {
                Tong += x;
                if (x > Max)
                {
                    Max = x;
                }
                if (x < Min)
                {
                    {
                        Min = x;
                    }
                }
            }
                double TrungBinh = (double)Tong / numbers.Count;

                Console.WriteLine();
                Console.WriteLine("Tong: " + Tong);
                Console.WriteLine("Trung binh: " + TrungBinh);
                Console.WriteLine("Min: " + Min);
                Console.WriteLine("Max: " + Max);
        }
        }
       
    }

