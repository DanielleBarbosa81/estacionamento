using Estacionamento;
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");
Console.WriteLine("Digite a placa do veículo que deseja estacionar:");
string placa = Console.ReadLine();  
Console.WriteLine("Digite o preço inicial do estacionamento:");
decimal precoInicial;
while (!decimal.TryParse(Console.ReadLine(), out precoInicial) || precoInicial < 0)
{
    Console.WriteLine("Preço inicial inválido. Por favor, digite um valor numérico positivo.");
}   
Console.WriteLine("Digite o preço por hora do estacionamento:");
decimal precoPorHora;
while (!decimal.TryParse(Console.ReadLine(), out precoPorHora) || precoPorHora < 0)
{
    Console.WriteLine("Preço por hora inválido. Por favor, digite um valor numérico positivo.");
}   
