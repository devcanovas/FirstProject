﻿using System.Runtime.InteropServices;
using System.Security.Cryptography;

string welcomeMessage = "Boas vindas ao Screen Sound";

Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>();
registeredBands.Add("Bring Me The Horizon", new List<int> { 10, 10, 10 });
registeredBands.Add("Slipknot", new List<int> { 8, 9, 10 });
registeredBands.Add("Linkin Park", new List<int> { 10, 10, 10 });

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
        case 1:
            InputBands();
            break;
        case 2:
            ShowBands();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção 3!");
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção 4!");
            break;
        case -1:
            Console.WriteLine("Tchau tchau!");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void InputBands()
{
    Console.Clear();
    BuildTitle("Registro de bandas");  
    Console.WriteLine("Digite o nome da banda que deseja registrar");
    string bandName = Console.ReadLine()!;
    registeredBands.Add(bandName, new List<int>());
    Console.WriteLine($"A banda {bandName} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ShowMenuOptions();
}

void ShowBands()
{
    Console.Clear();
    BuildTitle("Exibindo lista de nomes das bandas registradas");
    foreach(string bandNames in registeredBands.Keys)
    {
        Console.WriteLine($"- {bandNames}");
    }
    Console.WriteLine("\nPressiona ENTER para voltar ao menu inicial!");
    Console.ReadKey();
    Console.Clear();
    ShowMenuOptions();
}

void BuildTitle(string title)
{
    string astherics = string.Empty.PadLeft(title.Length, '*');
    Console.WriteLine(astherics);
    Console.WriteLine(title);
    Console.WriteLine($"{astherics}\n");
}

ShowMenuOptions();