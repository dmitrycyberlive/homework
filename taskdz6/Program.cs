//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
            
            string input = Console.ReadLine();
            
            int thirdDigit = int.Parse(input.Substring(2, 1));
            
            Console.WriteLine("Третья цифра: " + thirdDigit);
            
            if (input.Length != 3)
            {
                Console.WriteLine("Третья цифра отсутствует.");
            }
                // ДОДЕЛАТЬ КОНЦОВКУ