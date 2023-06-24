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

        public static ML.Result Add(ML.Paciente paciente)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.HospitalEntities context=new DL.HospitalEntities())
                {
                    int query = context.Addpaciente(paciente.Nombre, paciente.AP, paciente.AM, paciente.FechaNacimiento, paciente.FechaIngreso, paciente.TipoSangre.IdTipoSangre, paciente.Sexo, paciente.Sintomas);
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

        public static ML.Result GetByIdPaciente(int IdPaciente)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.HospitalEntities context=new DL.HospitalEntities())
                {
                    var query = context.GetByIdpaciente(IdPaciente).FirstOrDefault();
                    result.Objects = new List<object>();
                    if (query!=null)
                    {
                        ML.Paciente paciente = new ML.Paciente();
                        paciente.IdPaciente = query.IdPaciente;
                        paciente.Nombre = query.Nombre;
                        paciente.AP = query.AP;
                        paciente.AM = query.AM;
                        paciente.FechaNacimiento = query.FechaNacimiento.Value;
                        paciente.FechaIngreso = query.FechaIngreso.Value;
                        paciente.TipoSangre = new ML.TipoSangre();
                        paciente.TipoSangre.IdTipoSangre = query.IdTipoSangre.Value;
                        paciente.TipoSangre.Nombre = query.NombreSangre;
                        paciente.Sexo = query.sexo;
                        paciente.Sintomas = query.Sintomas;

                        result.Objects.Add(paciente);
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

        public static ML.Result Update(ML.Paciente paciente)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.HospitalEntities context=new DL.HospitalEntities())
                {
                    int query = context.UpdatePaciente(paciente.IdPaciente, paciente.Nombre,paciente.AP,paciente.AM, paciente.FechaNacimiento, paciente.FechaIngreso, paciente.TipoSangre.IdTipoSangre, paciente.Sexo, paciente.Sintomas);
                    if (query >= 1)
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

        public static ML.Result DeletePaciente(int IdPaciente)
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.HospitalEntities context=new DL.HospitalEntities())
                {
                    int query = context.DeletePaciente(IdPaciente);
                    if (query >= 1)
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
