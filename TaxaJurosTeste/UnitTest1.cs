using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteSquadra.Controllers;

using TesteSquadra.Repository;

namespace TaxaJurosTeste
{
    [TestClass]
    public class UnitTest1
    {
        //private readonly ICalcularJuros _ServicoCalcularJuros;
        //private readonly ITaxaJuros _ServicoTaxaJuros;

        [TestMethod]
        
        public void CalcularJurosErroMeses()
        {
            decimal valorInicial;
            int meses;
            decimal taxaJuros;
            valorInicial = 100;
            meses = -1;
            taxaJuros = 0.01M;
            decimal expected = 105.1M;

            CalcularJurosRepository CalcularJuros = new CalcularJurosRepository();
            decimal ret =  CalcularJuros.RetornaCalcularJuros(valorInicial, meses, taxaJuros);
            Assert.AreNotEqual(expected, ret);
            
        }

        [TestMethod]
        public void CalcularJurosOk()
        {
            decimal valorInicial;
            int meses;
            decimal taxaJuros;
            valorInicial = 100;
            meses = 5;
            taxaJuros = 0.01M;
            CalcularJurosRepository CalcularJuros = new CalcularJurosRepository();
            decimal ret = CalcularJuros.RetornaCalcularJuros(valorInicial, meses, taxaJuros);
            decimal expected = 105.1M;
            Assert.AreEqual(expected, ret);
        }
    }
}
