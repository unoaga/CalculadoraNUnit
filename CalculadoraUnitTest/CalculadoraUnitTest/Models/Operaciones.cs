using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculadoraUnitTest.Models
{
    public class Operaciones
    {
        public string numero1 { get; set; }
        public string numero2 { get; set; }
        public string operador { get; set; }
        public string resultado { get; set; }
        public Operaciones(string num1, string num2, string op, string res) 
        {
            this.numero1 = num1;
            this.numero2 = num2;
            this.operador = op;
            this.resultado = res;
        }
    }
}