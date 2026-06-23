using System;
using System.Data;
using System.Security.Authentication;

class DaysInMonth
{
    // Ham kiem tra nam nhuan
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 == 0) || (year % 400 == 0);
    }

    public static void Main4()
    {
        int month, year;
        int days;

        Console.WriteLine("Kiem tra co bao nhieu ngay trong thang/nam can kiem tra");

        Console.Write("Nhap thang (1 - 12): ");
        month = int.Parse(Console.ReadLine());

        if (month < 1 || month > 12)
        {
            Console.WriteLine("Thang vua nhap khong hop le, vui long nhap lai!");
            return;
        }

        Console.Write("Nhap nam: ");
        year = int.Parse(Console.ReadLine());

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                days = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                days = 30;
                break;
            case 2:
                if (IsLeapYear(year))
                {
                    days = 29;
                } else
                {

                    days = 28;
                }
                break;
            default:
                days = 0;
                break;
        }

        Console.WriteLine("\nKet qua: ");
        Console.WriteLine("Thang {0} nam {1} co {2} ngay!", month, year, days);
    }
}