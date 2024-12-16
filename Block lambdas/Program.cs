using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введіть речення: ");
        string input = Console.ReadLine();

        // Блоковий лямбда-вираз
        Func<string, string[]> processSentence = sentence =>
        {
            // Розділити на слова та перетворити першу літеру на велику
            return sentence
                .Split(' ')
                .Select(word => char.ToUpper(word[0]) + word.Substring(1))
                .ToArray();
        };

        // Виконання
        string[] result = processSentence(input);
        Console.WriteLine("Результат:");
        Console.WriteLine(string.Join(" ", result));
    }
}
