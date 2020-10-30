using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteSquadra.Interface
{
    public interface ICalcularJuros
    {
        decimal RetornaCalcularJuros(decimal valorInicial, int meses, decimal taxaJuros);
    }
}
