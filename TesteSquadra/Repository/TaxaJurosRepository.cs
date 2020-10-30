using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSquadra.Interface.Repository;

namespace TesteSquadra.Repository
{
    public class TaxaJurosRepository: ITaxaJurosRepository
    {
        public decimal RetornaTaxaJuros()
        {

            return 0.01M;
        }
    }
}
