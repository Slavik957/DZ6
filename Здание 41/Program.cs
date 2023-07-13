// Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Write("Введите количество чисел: ");
        int totalNumbers = int.Parse(Console.ReadLine()); // вводим количество чисел

        int countPositiveNumbers = 0; // переменная для подсчета чисел больше 0

        for (int i = 0; i < totalNumbers; i++)
        {
            Console.Write($"Введите число #{i + 1}: ");
            int number = int.Parse(Console.ReadLine()); // вводим число

            if (number > 0) // проверяем, больше ли число нуля
            {
                countPositiveNumbers++; // увеличиваем счетчик, если число больше 0
            }
        }

        Console.WriteLine($"Количество чисел больше 0: {countPositiveNumbers}");