using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Estacionamento
    {
        private decimal precoInicial;
        private decimal precoPorHora;
        private decimal precoTotal;
        public decimal PrecoTotal
        {
            get { return precoTotal; }
            private set { precoTotal = precoInicial * precoPorHora; }
        }
        private List<string> veiculosEstacionados;
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            this.veiculosEstacionados = new List<string>();
        }
        public void EstacionarVeiculo(string placa)
        {
            if (!veiculosEstacionados.Contains(placa))
            {
                veiculosEstacionados.Add(placa);
                Console.WriteLine($"Veículo {placa} estacionado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Veículo {placa} já está estacionado.");
            }
        }
    }
}