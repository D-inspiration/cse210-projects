using System;

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Fraction r1 = new Fraction();
        Console.WriteLine(r1.ToString());
        Console.WriteLine(r1.ToDecimal());

        Fraction r2 = new Fraction(5);
        Console.WriteLine(r2.ToString());
        Console.WriteLine(r2.ToDecimal());

        Fraction r3 = new Fraction(3, 4);
        Console.WriteLine(r3.ToString());
        Console.WriteLine(r3.ToDecimal());

        Fraction r4 = new Fraction(1, 3);
        Console.WriteLine(r4.ToString());
        Console.WriteLine(r4.ToDecimal());
    }
}
