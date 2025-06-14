using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Estacionamento

    {
        public Double valorHora { get; set; }
        public Double valorHoraExcedente { get; set; }
        public Double valorDiaria { get; set; }
        public DateTime DataHoraEntrada { get; set; }
        public DateTime DataHoraSaida { get; set; }
        public List<Veiculo> veiculos = new List<Veiculo>();


        

        public void AdicionarVeiculo(Veiculo veiculo)
        {
            veiculos.Add(veiculo);
        }

        public void RemoverVeiculo(Veiculo veiculo)
        {
            if (veiculos.Contains(veiculo))
            {
                veiculos.Remove(veiculo);
            }
            else
            {
                throw new Exception ("Veículo não encontrado")
            }
        public void CalcularValor{

        }

        }
    }
}