
PersonClass p1  = new PersonClass("Phuc", 20);
PersonClass p2 = p1;
p2.Age = 25;
Console.WriteLine($"p1: {p1.Age}");
Console.WriteLine($"p2: {p2.Age}");
Console.WriteLine($"{p1.Equals(p2)}");

PersonStruct p3 = new PersonStruct("Phuc", 20);
PersonStruct p4 = p3;
p4.Age = 25;
Console.WriteLine($"p1: {p3.Age}");
Console.WriteLine($"p2: {p4.Age}");
Console.WriteLine($"{p3.Equals(p4)}");

