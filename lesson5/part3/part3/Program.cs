using System;
using System.IO;
using System.Text.Json;


namespace part3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 0 до 255 для сохранения в бинарном формате:");
            var input = Convert.ToByte(Console.ReadLine());
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("text.txt", FileMode.OpenOrCreate), input );

        }
    }
}