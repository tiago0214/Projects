using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Seja bem-vindo!\nDigite uma opção no menu!");
            Console.WriteLine("---------------");
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            int valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1: Somar(); break;
                case 2: Subtrair(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default:
                    Console.WriteLine("Opção invalida");
                    break;
            }


        }
        static void Somar()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine($"A soma dos dois valores é: {resultado}");

            Console.WriteLine("");
            Console.WriteLine("1 - para fazer outra operação");
            Console.WriteLine("2 - para sair");
            int valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1: Menu(); break;
                case 2: Console.Clear(); break;
                default: Console.WriteLine("Opção invalida, desligando o sistema."); break;
            }
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

            Console.WriteLine("");
            Console.WriteLine("1 - para fazer outra operação");
            Console.WriteLine("2 - para sair");
            int valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1: Menu(); break;
                case 2: Console.Clear(); break;
                default: Console.WriteLine("Opção invalida, desligando o sistema."); break;
            }

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

            Console.WriteLine("");
            Console.WriteLine("1 - para fazer outra operação");
            Console.WriteLine("2 - para sair");
            int valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1: Menu(); break;
                case 2: Console.Clear(); break;
                default: Console.WriteLine("Opção invalida, desligando o sistema."); break;
            }

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

            Console.WriteLine("");
            Console.WriteLine("1 - para fazer outra operação");
            Console.WriteLine("2 - para sair");
            int valor = int.Parse(Console.ReadLine());

            switch (valor)
            {
                case 1: Menu(); break;
                case 2: Console.Clear(); break;
                default: Console.WriteLine("Opção invalida, desligando o sistema."); break;
            }

        }
    }
}
