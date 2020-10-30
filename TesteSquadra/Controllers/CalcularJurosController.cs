using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteSquadra.Interface;

namespace TesteSquadra.Controllers
{
    
    public class CalcularJurosController : ControllerBase
    {
        private readonly ICalcularJuros _ServicoCalcularJuros;
        private readonly ITaxaJuros _ServicoTaxaJuros;

        public CalcularJurosController(ICalcularJuros ServicoCalcularJuros, ITaxaJuros ServicoTaxajuros)
        {
            _ServicoCalcularJuros = ServicoCalcularJuros;
            _ServicoTaxaJuros = ServicoTaxajuros;
        }

        [HttpGet, Route("CalculaJuros/{valorInicial:decimal}/{meses:int}")]
        public decimal Get(decimal valorInicial, int meses)
        {
            decimal taxaJuros = _ServicoTaxaJuros.RetornaTaxaJuros();
            return _ServicoCalcularJuros.RetornaCalcularJuros(valorInicial, meses, taxaJuros);
        }
        //[HttpGet, Route("CalculaJuros")]
        //public decimal Get(decimal valorInicial, int meses)
        //{
        //    valorInicial = 100;
        //    meses = 5;
        //    decimal taxaJuros = _ServicoTaxaJuros.RetornaTaxaJuros();
        //    return _ServicoCalcularJuros.RetornaCalcularJuros(valorInicial, meses, taxaJuros);
        //}

        [HttpGet, Route("showmethecode")]
        public object ShowMeTheCode()
        {

            return "https://github.com/rafaelcarlins/TesteSquadra";
        }
    }
}
