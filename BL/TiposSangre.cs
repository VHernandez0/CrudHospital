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
                   
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            
            
            return result;
        }
    }
}
