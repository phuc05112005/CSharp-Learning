using System;

class Program2
{   
    enum nhietDoNuoc: int
    {
        DoDong = 0,
        DoNguoi = 20,
        DoAm = 40,
        DoNong = 60,
        DoSoi = 100
    }

    public static void Main2()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        nhietDoNuoc nhietDo = nhietDoNuoc.DoSoi;
        Console.WriteLine($"Nhiệt độ: {nhietDo}");
        Console.WriteLine($"Giá trị: {(int)nhietDo}");
    }
}