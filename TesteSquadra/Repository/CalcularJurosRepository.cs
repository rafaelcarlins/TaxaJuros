using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSquadra.Interface.Repository;

namespace TesteSquadra.Repository
{
    public class CalcularJurosRepository : ICalcularJurosRepository
    {
        public decimal RetornaCalcularJuros(decimal valorInicial, int meses, decimal taxaJuros)
        {
            var potencia = (decimal)Math.Pow(1 + ((double)taxaJuros), meses);
            var valorCheio = Convert.ToDecimal(valorInicial * potencia);
            var valorCalculado = Math.Round(valorCheio, 2);
            return valorCalculado;
        }
    }
}
