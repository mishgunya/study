using System;


namespace part1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                Console.WriteLine($"{nameof(Process.ProcessName)}: {process.ProcessName}, {nameof(Process.Id)}: {process.Id}");
            }

            Console.WriteLine();
            Console.WriteLine("Введите ID процесса, который нужно кильнуть:");
            var pId = Convert.ToInt32(Console.ReadLine());
            var pkill = Process.GetProcessById(pId);
            pkill.Kill();
        }
    }
}