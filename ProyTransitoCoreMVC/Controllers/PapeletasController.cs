using Microsoft.AspNetCore.Mvc;
using ProyTransitoCoreMVC.Models;
using System.Linq;

namespace ProyTransitoCoreMVC.Controllers
{
    public class PapeletasController : Controller
    {
        //definir la variables del contexto del entity framework core
        BDTRANSITO22Context bd =new BDTRANSITO22Context();

        //listado de papeletas
        public IActionResult ListarPapeletas()
        {
            //obtener datos del modelo
            var listado = bd.Papeletas.ToList();

            //enviar los datos del modelo a la vista
            return View(listado);
        }

        //Consulta de papeletas por policia
        public IActionResult PapeletasPolicia(string codpol = "P0002")
        {
            //LINQ expresion de consulta
            var listado1 = (from p in bd.Papeletas
                           where p.Codpol.Equals(codpol)
                           select p).ToList();

            //LINq - expresion Lambda
            var listado2 = bd.Papeletas
                            .Where(p => p.Codpol.Equals(codpol))
                            .ToList();
            return View(listado1);
        }
    }
}
