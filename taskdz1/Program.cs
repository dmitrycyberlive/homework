
        
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} больше, чем {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num2} больше, чем {num1}");
            }
            else
            {
                Console.WriteLine($"число равно: {num1} = {num2}");
            }


