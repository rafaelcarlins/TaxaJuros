using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSquadra.Interface.Repository
{
    public interface ICalcularJurosRepository
    {
        decimal RetornaCalcularJuros(decimal valorInicial, int meses, decimal taxaJuros);
    }
}
