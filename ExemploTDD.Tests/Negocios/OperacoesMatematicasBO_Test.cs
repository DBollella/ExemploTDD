using ExemploTDD.Negocios;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploTDD.Tests.Negocios
{
    [TestFixture]
    public class OperacoesMatematicasBO_Test
    {
        [TestCase(1, 1, 1)]
        [TestCase(10, 2, 20)]
        [TestCase(10, 10, 1000)]
        public void Multiplicacao(int entrada1 ,int entrada2, int resultadoEsperado)
        {
            OperacoesMatematicasBO negocio = new OperacoesMatematicasBO();
            var resultadoMetodo = negocio.Multiplicacao(entrada1, entrada2);
            Assert.AreEqual(resultadoEsperado, resultadoMetodo);
        }
    }
}
