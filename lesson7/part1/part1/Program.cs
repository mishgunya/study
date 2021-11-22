using System;

namespace part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double num = 0.0;
            Console.WriteLine("Введите первое число");
            double int32_1 = (double) Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double int32_2 = (double) Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите операцию (1-сложение,2-вычитание,3-умножение,4-деление)");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    num = int32_1 + int32_2;
                    break;
                case 2:
                    num = int32_1 - int32_2;
                    break;
                case 3:
                    num = int32_1 * int32_2;
                    break;
                case 4:
                    num = int32_1 / int32_2;
                    break;
                default:
                    Console.WriteLine("Вы ввели число вне диапазона");
                    break;
            }
            Console.WriteLine(string.Format("Ваш результат:{0}", (object) num));
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}