using System;

namespace Lesson_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число");
            int CheckValue = int.Parse(Console.ReadLine());
            int i = 2;
            if (CheckValue == 1)
            {
                Console.WriteLine($"{CheckValue} не простое число");
            }
            else if (CheckValue > 1)
            {
                while (i < CheckValue)
                {
                    if (CheckValue % i == 0)
                    {
                        Console.WriteLine($"{CheckValue} не простое число");
                        goto M1;
                    }
                    else
                    {    
                        ++i;
                    }
                }
                Console.WriteLine($"{CheckValue} простое число");
            }
            else
            {
                Console.WriteLine("Не корректное значение");
            }
        M1:
            Console.ReadKey();
        }
    }
}
