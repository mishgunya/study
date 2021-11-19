using System;

namespace part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var input = Console.ReadLine();
            File.WriteAllText("file.txt" ,input);
        }
        
    }
}