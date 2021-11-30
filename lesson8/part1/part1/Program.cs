using System;
using System.Configuration;
using System.IO;
using Microsoft.Azure.Amqp.Framing;
using Microsoft.Extensions.Configuration;
using ConfigurationBuilder = System.Configuration.ConfigurationBuilder;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace part1

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {

                Console.WriteLine("Введите имя пользователя:");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            string userName = Properties.Settings.Default.UserName;
            string greeting = Properties.Settings.Default.Greeting;
            Console.WriteLine($"{greeting}, {userName}!");




        }
    }
}