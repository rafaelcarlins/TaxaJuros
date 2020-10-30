using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSquadra.Interface;
using TesteSquadra.Interface.Repository;

namespace TesteSquadra.Services
{
    public class CalcularJurosService : ICalcularJuros
    {
        private readonly ICalcularJurosRepository _repository;

        public CalcularJurosService(ICalcularJurosRepository repository)
        {
            _repository = repository;
        }
        public  decimal RetornaCalcularJuros(decimal valorInicial, int meses, decimal taxaJuros)
        {
            
            return _repository.RetornaCalcularJuros( valorInicial,  meses,  taxaJuros);
        }
    }
}
