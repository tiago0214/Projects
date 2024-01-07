using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine($"A soma dos dois valores é: {resultado}");
        }
        static void Subtrair()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"A subtração dos dois valores é: {resultado}");
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($"A multiplicação dos dois valores é: {resultado}");
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine($"A divisao dos dois valores é: {resultado}");
        }
    }


}
