using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Veiculo
    {
        public string placa { get; set; }
        public DateTime dataHoraEntrada { get; set; }
        public DateTime dataHoraSaida { get; set; }
    }
}