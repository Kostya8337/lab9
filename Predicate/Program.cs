using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть число: ");
        int number = int.Parse(Console.ReadLine());

        // Лямбда-вираз Predicate
        Predicate<int> isDivisibleBy7 = n => n % 7 == 0;

        // Перевірка
        Console.WriteLine(isDivisibleBy7(number)
            ? "Число ділиться на 7."
            : "Число НЕ ділиться на 7.");
    }
}
