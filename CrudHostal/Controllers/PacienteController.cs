using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudHostal.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult GetAll()
        {
            ML.Result result = BL.Paciente.GetAll();
            if (result.Correct)
            {
                ML.Paciente paciente = new ML.Paciente();
                paciente.Pacientes = new List<object>();
                paciente.Pacientes = result.Objects;
                return View(paciente);
            }
            else
            {
                ViewBag.Message = "Ha ocurrido Un error";
                return View("Modal");
            }
           
        }
        [HttpPost]
        public ActionResult form(ML.Paciente paciente,byte IdSangre)
        {
            ML.Result result = BL.Paciente.Add(paciente, IdSangre);
            if (result.Correct)
            {
                ViewBag.Message = "Se inserto el paciente con exito";
                
            }
            else
            {
                ViewBag.Message = "ha ocurrido un error con exito";
                
            }
            return View("Modal");
        }
    }
}