using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraUnitTest
{
    public class OporacionesCalculadora
    {
        public string Suma(string num1, string num2)
        {
            try 
            {
                var resultado = "" + (double.Parse(num1) + double.Parse(num2));
                return resultado;
            }
            catch (FormatException)
            {
                return "No puedes ingresar letras solo números";
            }
            
        }

        public string Resta(string num1, string num2)
        {
            try
            {
                var resultado = "" + (double.Parse(num1) - double.Parse(num2));
                return resultado;
            }
            catch (FormatException)
            {
                return "No puedes ingresar letras solo números";
            }
        }

        public string Multiplicacion(string num1, string num2)
        {
            try
            {
                var resultado = "" + (double.Parse(num1) * double.Parse(num2));
                return resultado;
            }
            catch (FormatException)
            {
                return "No puedes ingresar letras solo números";
            }
        }

        public string Division(string num1, string num2)
        {
            try
            {
                var resultado = "" + (double.Parse(num1) / double.Parse(num2));
                return resultado;
            }
            catch (FormatException)
            {
                return "No puedes ingresar letras solo números";
            }
        }
        public string Porcentaje(string num1, string num2)
        {
            try
            {
                var resultado = "" + ((double.Parse(num1) / 100) * double.Parse(num2));
                return resultado;
            }
            catch (FormatException)
            {
                return "No puedes ingresar letras solo números";
            }
           
        }


        public string Raiz(string num1)
        {
            try
            {
                var resultado = "" + System.Math.Sqrt(double.Parse(num1));
                return resultado;
            }
            catch (FormatException)
            {
                return "No puedes ingresar letras solo números";
            }
            
        }
    }
}