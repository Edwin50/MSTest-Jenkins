using Microsoft.VisualStudio.TestTools.UnitTesting;
using Semana7PU;

namespace Semana7Test
{
    [TestClass]
    public class CalcuTest
    {
        [DataRow(4,4,8)]
        [DataRow(4, 0, 4)]
        [DataRow(0, 0, 0)]
        [TestMethod]
        public void Suma_retonaValor(int a,int b, int esperado)
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



        /// <summary>
        /// EDWIN Agregado Restorna la resta de dos numeros, recordar p+p = p , n+n=n , p-n= p 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="esperado"></param>
        [DataRow(-5, 4, -9)]
        [DataRow(4, 51, 47)]
        [DataRow(6, -1, 7)]
        [TestMethod]
        public void Resta_retonaValor(int a, int b, int esperado)
        {
            //arrange
          
            //Act

            //Assert

            Assert.AreEqual(esperado, Calculadora.resta(a, b));

        }

        /// <summary>
        /// EDWIN Agregado multiplica valores, al multiplicar la de diferentes signos queda negativo, signos iguales positivo      /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="esperado"></param>
        [DataRow(105, 0, 0)]
        [DataRow(4, 8, -32)]
        [DataRow(-3, -5, -15)]
        [TestMethod]
        public void Multiplica_retonaValor(int a, int b, int esperado)
        {
            //arrange

            //Act

            //Assert

            Assert.AreEqual(esperado, Calculadora.multi(a, b));

        }

    }
}
