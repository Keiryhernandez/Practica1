using Microsoft.AspNetCore.Mvc;
using Practica1.Models;

namespace Practica1.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Index()
        {
            var model = new Operaciones();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Operaciones model)
        {
            if (ModelState.IsValid)
            {
                if (model.TipoOperacionId == 1) // Kilómetros a Millas
                {
                    model.Resultado = model.PrimerDato * 0.621371;
                }
                else if (model.TipoOperacionId == 2) // Millas a Kilómetros
                {
                    model.Resultado = model.PrimerDato / 0.621371;
                }
                else if (model.TipoOperacionId == 3) // Metros a Pies
                {
                    model.Resultado = model.PrimerDato * 3.28084;
                }
                else if (model.TipoOperacionId == 4) // Pies a Metros
                {
                    model.Resultado = model.PrimerDato / 3.28084;
                }
            }
            return View(model);
        }
    }


}
