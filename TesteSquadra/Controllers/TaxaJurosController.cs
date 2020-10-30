using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteSquadra.Interface;
using TesteSquadra.Services;

namespace TesteSquadra.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJuros _ServicoTaxaJuros;
        
        public TaxaJurosController(ITaxaJuros ServicoTaxajuros)
        {
            _ServicoTaxaJuros = ServicoTaxajuros;
        }
        
        [HttpGet]
        public decimal Get()
        {
            return _ServicoTaxaJuros.RetornaTaxaJuros();
        }
    }
}
