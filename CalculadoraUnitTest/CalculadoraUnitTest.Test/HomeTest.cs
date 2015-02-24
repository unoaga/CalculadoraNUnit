using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculadoraUnitTest.Controllers;
using NUnit.Framework;
namespace CalculadoraUnitTest.Test
{
     [TestFixture]
    public class HomeTest
    {

         public OporacionesCalculadora hc;

        public HomeTest() 
        {
            hc = new OporacionesCalculadora();
        }

         [Test]
        public void Suma()
        {
            var result = hc.Suma("10", "23");
            Assert.AreEqual("33", result);
        }

         [Test]
        public void Resta()
        {
            var result = hc.Resta("23", "10");
            Assert.AreEqual("13", result);
        }

         [Test]
        public void Multiplicacion()
        {
            var result = hc.Multiplicacion("10", "23");
            Assert.AreEqual("230", result);
            
        }

         [Test]
        public void Division()
        {
            var result = hc.Division("23", "10");
            Assert.AreEqual("2.3", result);
        }

         [Test]
        public void Porcentaje()
        {
            var result = hc.Porcentaje("200", "20");
            Assert.AreEqual("40", result);
        }


         [Test]
        public void Raiz()
        {
            var result = hc.Raiz("16");
            Assert.AreEqual("4", result);
        }


         [Test]
         public void SumaInvalidFormat()
         {
             var result = hc.Suma("weq", "23");
             Assert.AreEqual("No puedes ingresar letras solo números", result);
         }

         [Test]
         public void RestaInvalidFormat()
         {
             var result = hc.Resta("23", "234d");
             Assert.AreEqual("No puedes ingresar letras solo números", result);
         }

         [Test]
         public void MultiplicacionInvalidFormat()
         {
             var result = hc.Multiplicacion("10", "ds3");
             Assert.AreEqual("No puedes ingresar letras solo números", result);
         }

         [Test]
         public void DivisionInvalidFormat()
         {
             var result = hc.Division("2ds", "10");
             Assert.AreEqual("No puedes ingresar letras solo números", result);
         }

         [Test]
         public void PorcentajeInvalidFormat()
         {
             var result = hc.Porcentaje("20w0", "20");
             Assert.AreEqual("No puedes ingresar letras solo números", result);
         }


         [Test]
         public void RaizInvalidFormat()
         {
             var result = hc.Raiz("1q6");
             Assert.AreEqual("No puedes ingresar letras solo números", result);
         }

         [Test]
         public void DivisionCero()
         {
             var result = hc.Division("10", "0");
             Assert.AreEqual("Infinito", result);
         }
    }
}
