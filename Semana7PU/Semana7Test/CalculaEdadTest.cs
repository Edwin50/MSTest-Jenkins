using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semana7PU;
namespace Semana7Test
{
    [TestClass]
   public class CalculaEdadTest
    {
        [DataRow(1984,38)]
        [TestMethod]
        public void CalculaEdad_by_year(int year, int esperado) {

            Assert.AreEqual(esperado, clsCalculaEdad.Calcular(year));
        }


    }
}
