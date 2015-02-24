using CalculadoraUnitTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalculadoraUnitTest.Controllers;

namespace CalculadoraUnitTest.Controllers
{
    public class HomeController : Controller
    {
        public OporacionesCalculadora hc;

        public HomeController() 
        {
            hc = new OporacionesCalculadora();
        }
        //
        // GET: /Home/
        string resultado;
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public string GetOperacion(string num1, string num2, string oper) 
        {

            Operaciones op = new Operaciones(num1, num2, oper, "0");
            switch(op.operador)
            {
                case "suma":
                    op.resultado = hc.Suma(op.numero1, op.numero2);
                    break;
                 case "resta":
                    op.resultado = hc.Resta(op.numero1, op.numero2);
                    break;
                 case "multiplicacion":
                    op.resultado = hc.Multiplicacion(op.numero1, op.numero2);
                    break;
                 case "division":
                    op.resultado = hc.Division(op.numero1, op.numero2);
                    break;
                 case "raiz":
                    op.resultado = hc.Raiz(op.numero1);
                    break;
                 case "porcentaje":
                    op.resultado = hc.Porcentaje(op.numero1, op.numero2);
                    break;
            }
            return op.resultado;
        }

    }
}
