using System;
using DesafioFinal.models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// variaveis do preço do estacionamento
decimal precoInicial = 0;
decimal precoPorHora = 0;

// Bem vindo do sistema 
Console.WriteLine($"Seja bem vindo ao sistema de estacionamento! \n digite o preço inicial: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento es = new Estacionamento(precoInicial, precoPorHora);


Console.WriteLine($"Digite sua opção \n opção 1. Cadastrar veículo\n opção 2. Remover veículos\n opção 3. listar veículos\n opção 4 encerrar.");
string opcoes = Console.ReadLine();
do
{
  Console.WriteLine($"Digite sua opção \n opção 1. adicionar veículo\n opção 2. Remover veículos\n opção 3. listar veículos\n opção 4 encerrar.");
  opcoes = Console.ReadLine();

  switch (opcoes)
  {
    case "1":
      es.AdicionarVeiculo();
     break;
    case "2":
     es.RemoverVeiculo();
     break;
     case "3":
     es.ListarVeiculos();
      break;
      case "4":
      Console.WriteLine("Encerrando programa");
     break;
    default:
    Console.WriteLine("Opção invalida");
    break;
  }
} while (opcoes != "4");