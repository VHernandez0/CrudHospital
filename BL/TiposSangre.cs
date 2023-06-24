using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TiposSangre
    {
        public static ML.Result GetAllSangre()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.HospitalEntities context=new DL.HospitalEntities())
                {
                    var query = context.GetAllSangre();
                    if (query != null)
                    {
                        result.Objects = new List<object>();
                       
                        foreach (var item in query)
                        {
                            ML.TipoSangre tipoSangre = new ML.TipoSangre();
                            tipoSangre.IdTipoSangre = item.IdTipoSangre;
                            tipoSangre.Nombre = item.Nombre;
                            result.Objects.Add(tipoSangre);

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
    }
}
