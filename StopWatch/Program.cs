using System;
using System.Runtime.InteropServices;


namespace StopWatch
{
    class Program
    {
        static void Main(String[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos");
            Console.WriteLine("M - Minutos");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar ?");

            string data = Console.ReadLine().ToLower();
            Console.WriteLine(data);

        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stop watch finalizado.");
            Thread.Sleep(2500);
        }
    }
}


