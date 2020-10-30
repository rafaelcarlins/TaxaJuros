using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSquadra.Interface;
using TesteSquadra.Interface.Repository;

namespace TesteSquadra.Services
{
    public class TaxaJurosService :ITaxaJuros
    {
        private readonly ITaxaJurosRepository _repository;

        public TaxaJurosService(ITaxaJurosRepository repository)
        {
            _repository = repository;
        }
        public  decimal RetornaTaxaJuros()
        {

            return _repository.RetornaTaxaJuros();
        }
    }
}
