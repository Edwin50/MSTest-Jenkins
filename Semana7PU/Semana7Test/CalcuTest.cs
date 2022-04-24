using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semana7PU;

namespace Semana7Test
{
  [TestClass]
  public class CalcuTest
  {
    [DataRow(4, 4, 8)]
    [DataRow(4, 0, 4)]
    [DataRow(0, 0, 0)]
    [TestMethod]
    public void Suma_retonaValor(int a, int b, int esperado)
    {
      //arrange
      //int a = 4;
      // int b = 4;
      // int esperado = 7;

      //Act

      int actual = Calculadora.suma(a, b);

      //Assert

      Assert.AreEqual(esperado, actual);

    }

    // Test Driven Development
    //programacion entre pares


    [DataRow(4, 4, 1)]
    [DataRow(4, 0, -1)]
    [DataRow(20, 5, 4)]
    [TestMethod]
    public void Div_retonaValor(int a, int b, int esperado)
    {
      //arrange
      //int a = 4;
      // int b = 4;
      // int esperado = 7;

      //Act

      Calculadora calc = new Calculadora();

      int actual = calc.div(a, b);

      //Assert

      Assert.AreEqual(esperado, actual);

    }


    [DataRow(4, 0, 0)]
    [TestMethod]
    public void Div_EntreCero(int a, int b, int esperado)
    {
      //arrange
      //int a = 4;
      // int b = 4;
      // int esperado = 7;

      //Act

      Calculadora calc = new Calculadora();

      int actual = calc.div(a, b);

      //Assert

      Assert.AreNotEqual(null, actual);

    }


    /* TAREA SEMANA 7
     * ALLAN QUIROS SOLANO
     * 
     */
    [DataRow(20, 50, -30)]
    [DataRow(0, 10, -10)]
    [TestMethod]
    public void Resta_ResultadoNegativo_RetornaResultadoNegativo(int primerNumero, int seguntoNumero, int resultadoEsperado)
    {
      // Act
      int actual = Calculadora.resta(primerNumero, seguntoNumero);

      // Assert
      Assert.AreEqual(resultadoEsperado, actual);
      Assert.IsTrue(actual < 0);
    }

    [DataRow(50, 50, 0)]
    [DataRow(1, 1, 0)]
    [TestMethod]
    public void Resta_ResultadoCero_RetornaResultadoCero(int primerNumero, int seguntoNumero, int resultadoEsperado)
    {
      // Act
      int actual = Calculadora.resta(primerNumero, seguntoNumero);

      // Assert
      Assert.AreEqual(resultadoEsperado, actual);
      Assert.IsTrue(actual == 0);
    }


    [DataRow(2, 5, 10)]
    [DataRow(5, 5, 25)]
    [DataRow(5, 1, 5)]
    [TestMethod]
    public void Multiplicacion_Correcta_RetornaValorEsperado(int primerNumero, int seguntoNumero, int resultadoEsperado)
    {
      // Act
      int actual = Calculadora.multi(primerNumero, seguntoNumero);

      // Assert
      Assert.AreEqual(resultadoEsperado, actual);
    }

    [DataRow(5, 0, 0)]
    [DataRow(0, 3, 0)]
    [DataRow(0, 0, 0)]
    [TestMethod]
    public void Multiplicacion_PorCero_RetornaCero(int primerNumero, int seguntoNumero, int resultadoEsperado)
    {
      // Act
      int actual = Calculadora.multi(primerNumero, seguntoNumero);

      // Assert
      Assert.AreEqual(resultadoEsperado, actual);
      Assert.IsTrue(actual == 0);
    }

  }
}
