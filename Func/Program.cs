using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть довжини трьох сторін трикутника (a, b, c): ");
        string[] input = Console.ReadLine().Split(' ');
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        // Лямбда-вираз
        Func<double, double, double, bool> isTriangle = (x, y, z) =>
            (x + y > z) && (x + z > y) && (y + z > x);

        // Перевірка
        Console.WriteLine(isTriangle(a, b, c)
            ? "Ці сторони утворюють трикутник."
            : "Ці сторони НЕ утворюють трикутник.");
    }
}
