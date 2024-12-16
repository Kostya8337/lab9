using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Лямбда-вираз
        Func<double, double> F = x => x > 0 ? Math.Pow(Math.Sin(x), 2) : 1 + 2 * Math.Pow(Math.Sin(x), 2);

        // Результат
        Console.WriteLine($"F(x) = {F(x)}");
    }
}
