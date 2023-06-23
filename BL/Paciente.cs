using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Paciente
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.HospitalEntities context=new DL.HospitalEntities())
                {
                    var query = context.GetAllPacientes();
                    if (query!=null)
                    {
                        result.Objects = new List<object>();
                        foreach (var item in query)
                        {
                            ML.Paciente paciente = new ML.Paciente();
                            paciente.IdPaciente = item.IdPaciente;
                            paciente.Nombre = item.Nombre;
                            paciente.AP = item.AP;
                            paciente.AM = item.AM;
                            paciente.FechaNacimiento = item.FechaNacimiento.Value;
                            paciente.FechaIngreso = item.FechaIngreso.Value;
                            paciente.TipoSangre = new ML.TipoSangre();
                            paciente.TipoSangre.IdTipoSangre = item.IdTipoSangre.Value;
                            paciente.TipoSangre.Nombre = item.NombreSangre;
                            paciente.Sexo = item.sexo;
                            paciente.Sintomas = item.Sintomas;
                            result.Objects.Add(paciente);

                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {

                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            
            return result;
        }

        public static ML.Result Add(ML.Paciente paciente,byte IdSangre)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.HospitalEntities context=new DL.HospitalEntities())
                {
                    int query = context.Addpaciente(paciente.Nombre, paciente.AP, paciente.AM, paciente.FechaNacimiento, paciente.FechaIngreso, IdSangre, paciente.Sexo, paciente.Sintomas);
                    if (query >0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {

                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }

            return result;
        }
    }
}
