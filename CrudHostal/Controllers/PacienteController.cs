using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudHostal.Controllers
{
    public class PacienteController : Controller
    {
        [HttpGet]
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
        public ActionResult form(ML.Paciente paciente)
        {
            paciente.FechaIngreso = DateTime.Today;
            if (paciente.IdPaciente==null)
            {
                ML.Result result = BL.Paciente.Add(paciente);
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
            else
            {

                if (true)
                {
                    ML.Result result = BL.Paciente.Update(paciente);
                    if (result.Correct)
                    {
                        ViewBag.Message = "Se actualizo con exito el Paciente";
                    }
                    else
                    {
                        ViewBag.Message = "Hubo un error con exito";
                    }
                    return View("Modal");
                }
            }
            
        }


        [HttpGet]
        public ActionResult form(int? IdPaciente)
        {
            ML.Result result1 = BL.TiposSangre.GetAllSangre();
            ML.Paciente paciente = new ML.Paciente();
            paciente.TipoSangre = new ML.TipoSangre();
            paciente.TipoSangre.Objects = result1.Objects;
            if (IdPaciente == null)
            {
                ML.Result result = BL.Paciente.GetAll();
                if (result.Correct)
                {
                   
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
            else
            {
                ML.Result result = BL.Paciente.GetByIdPaciente(IdPaciente.Value);
                if (result.Correct)
                {
                   
                    paciente.Pacientes = result.Objects;
                    return View(paciente);
                }
                else
                {
                    ViewBag.Message = "ha ocurrido un error";
                    return View("Modal");
                }
            }
        }
        [HttpGet]
        public ActionResult Delete( int IdPaciente)
        {
            ML.Result result = BL.Paciente.DeletePaciente(IdPaciente);
            if (result.Correct)
            {
                ViewBag.Message = "Se ha eliminado con exito";

            }
            else
            {
                ViewBag.Message = "ha ocurrido un error con exito";
            }
            return View("Modal");
        }
    }
}