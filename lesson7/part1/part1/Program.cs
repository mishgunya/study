using System;

namespace part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double result = 0;
            Console.WriteLine("Введите первое число");
            double input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите операцию (1-сложение,2-вычитание,3-умножение,4-деление)");
            var input3 = Convert.ToInt32(Console.ReadLine());
            if (input3 == 1)
            {
                result = input1 + input2;
            }
            else if (input3 == 2)
            {
                result = input1 - input2;
            }
            else if (input3 == 3)
            {
                result = input1 * input2;
            }
            else if (input3 == 4)
            {
                result = input1 / input2;
            }
            else
            {
                Console.WriteLine("Вы ввели число вне диапазона");
            }

            Console.WriteLine($"Ваш результат:{result}");
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();


        }
    }
}