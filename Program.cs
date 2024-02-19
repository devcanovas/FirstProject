using System.Security.Cryptography;

string welcomeMessage = "Bosa vindas ao Screen Sound";
List<string> bandList = new List<string> { "Bring Me The Horizon", "Slipknot", "Linkin Park" };

void ShowLogo()
{
    Console.WriteLine(@"
    
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");

    Console.WriteLine(welcomeMessage);
}

void ShowMenuOptions()
{
    ShowLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.WriteLine("\nDigite a sua opção:");
    int optionChoosed = int.Parse(Console.ReadLine()!);

    handleOption(optionChoosed);
}

void handleOption(int opt)
{
    switch (opt)
    {
        case 1: Console.WriteLine("Você escolheu a opção 1!");
            break;
        case 2: Console.WriteLine("Você escolheu a opção 2!");
            break;
        case 3: Console.WriteLine("Você escolheu a opção 3!");
            break;
        case 4: Console.WriteLine("Você escolheu a opção 4!");
            break;
        case -1: Console.WriteLine("Tchau tchau!");
            break;
        default: Console.WriteLine("Opção inválida!");
            break;
    }
}
