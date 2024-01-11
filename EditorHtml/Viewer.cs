using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO HTML");
            Console.WriteLine("------------");
            Replace(text);
            Console.ReadKey();
            Menu.Show();

        }

        public static void Replace(string text)
        {
            var strong = new Regex(@$"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        }
        //outro modo de testar, o indexOF do primeiro"<" e o ultimo index do > e tentar pegar tudo dentro 

    }
}