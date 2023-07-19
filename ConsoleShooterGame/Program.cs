using System;
using System.Threading;

namespace ConsoleShooterGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            string power = "";

            int number;

            Random random = new Random();

            int EnemyHealth = random.Next(1, 2000);

            Console.Write("Введи свое имя: ");
            playerName = Console.ReadLine();

            Console.Write("Какая мощность пушки?: ");
            power = Console.ReadLine();

            bool isValidInput = false;

            do
            {
                Console.Write("Какая мощность пушки?: ");
                power = Console.ReadLine();

                if (int.TryParse(power, out number))
                {
                    isValidInput = true;

                    if (EnemyHealth < number)
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine($"{playerName} убивает врага");
                        Thread.Sleep(1000);
                        Console.WriteLine(EnemyHealth);
                    }
                    else if (EnemyHealth > number)
                    {
                        Console.WriteLine("Поражение");
                        Thread.Sleep(1000);
                        int result = EnemyHealth - number;
                        Console.WriteLine($"{result} осталось здоровье врага");
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }
            } while (!isValidInput);
        }
    }
}
