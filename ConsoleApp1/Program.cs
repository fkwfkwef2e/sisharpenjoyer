using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Игра 'Угадай число'");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выход");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
            {
                break;
            }
            else if (choice == 1)
            {
                GuessNumber();
            }
            else if (choice == 2)
            {
                MultiplicationTable();
            }
            else if (choice == 3)
            {
                FindDivisors();
            }
            else
            {
                Console.WriteLine("Некорректный выбор. Попробуйте снова.");
            }
        }
    }

    static void GuessNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);

        while (true)
        {
            Console.Write("Введите число: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber == randomNumber)
            {
                Console.WriteLine("Поздравляю, вы угадали число!");
                break;
            }
        }
    }

    static void MultiplicationTable()
    {
        int[,] table = new int[10, 10];

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                table[i - 1, j - 1] = i * j;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void FindDivisors()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Делители числа " + number + ": ");
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}