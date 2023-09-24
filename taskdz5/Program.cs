// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
            
            string input = Console.ReadLine();
            
            int secondDigit = int.Parse(input.Substring(1, 1));
            
            Console.WriteLine("Вторая цифра: " + secondDigit);
