
class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que você deseja fazer? ");
        Console.WriteLine("1 - Abrir arquivo.");
        Console.WriteLine("2 - Criar novo arquivo.");
        Console.WriteLine("0 - Sair.");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Open(); break;
            case 2: Editor(); break;
        }
    }

    static void Open()
    {
        Console.Clear();
        Console.WriteLine("Qual o caminho do arquivo?");
        string path = Console.ReadLine();

        using (var file = new StreamReader(path))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }

        Console.WriteLine("");
        Console.ReadLine();
        Menu();

    }
    static void Editor()
    {
        Console.Clear();
        Console.WriteLine("Digite o seu texto (ESC - para sair)!");
        Console.WriteLine("--------------------");
        string text = "";


        do
        {
            text += Console.ReadLine();
            text += Environment.NewLine;
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);
        Salvar(text);

    }
    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Qual caminho para salvar o arquivo?");
        var path = Console.ReadLine();

        //Estou usando o using, para abrir e fechar automaticamente o meu arquivo
        //Posso fazer direto sem o using, porém, eu tenho que fechar o arquivo com a função close
        //sempre que eu vou abrir ou editar um arquivo, eu preciso do using.
        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }
        Console.WriteLine($"Arquivo {path} salvo com sucesso");
        Console.ReadLine();
        Menu();
    }
}