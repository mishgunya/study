using System;
using System.IO;



namespace part2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hello!");
            var time = DateTime.Now;
            string ct = time.ToString("dd MMMM yyyy hh:mm:ss tt");
            File.AppendAllLines("startup.txt", new []{ct});
        }
    }
}