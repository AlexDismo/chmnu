namespace Lab1;

public class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("=== Меню вибору ===");
            Console.WriteLine("1. Вивести кількість слів з тексту 'Lorem ipsum'");
            Console.WriteLine("2. Виконати математичну операцію");
            Console.WriteLine("3. Вийти");
            Console.Write("Виберіть пункт меню: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PrintLoremIpsumWords();
                    break;
                case "2":
                    PerformMathOperation();
                    break;
                case "3":
                    exit = true;
                    Console.WriteLine("До побачення!");
                    break;
                default:
                    Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }

    static void PrintLoremIpsumWords()
    {
        string filePath = "lorem.txt";
        if (File.Exists(filePath))
        {
            string loremText = File.ReadAllText(filePath);
            Console.Write("Скільки слів вивести? ");
            if (int.TryParse(Console.ReadLine(), out int wordCount))
            {
                string[] words = loremText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 1; i < Math.Min(wordCount, words.Length); i++)
                {
                    Console.Write(words[i] + " ");
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть коректне число.");
            }
        }
        else
        {
            Console.WriteLine("Файл не знайдено.");
        }
    }

    static void PerformMathOperation()
    {
        Console.Write("Введіть перше число: ");
        if (double.TryParse(Console.ReadLine(), out double number1))
        {
            Console.Write("Введіть друге число: ");
            if (double.TryParse(Console.ReadLine(), out double number2))
            {
                Console.WriteLine("Оберіть операцію (+, -, *, /): ");
                string operation = Console.ReadLine();
                double result;

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        Console.WriteLine($"Результат: {number1} + {number2} = {result}");
                        break;
                    case "-":
                        result = number1 - number2;
                        Console.WriteLine($"Результат: {number1} - {number2} = {result}");
                        break;
                    case "*":
                        result = number1 * number2;
                        Console.WriteLine($"Результат: {number1} * {number2} = {result}");
                        break;
                    case "/":
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                            Console.WriteLine($"Результат: {number1} / {number2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Ділення на нуль неможливе.");
                        }
                        break;
                    default:
                        Console.WriteLine("Невідома операція.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некоректне друге число.");
            }
        }
        else
        {
            Console.WriteLine("Некоректне перше число.");
        }
    }
}
