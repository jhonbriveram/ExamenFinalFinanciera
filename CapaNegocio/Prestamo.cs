using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
   public class Prestamo
    {
        //public static  Prestamo Registrar()
        //{
        //    using (var db = new FinancieraEntities())
        //    {
        //        return db.Prestamo;
        //    }
        //}
        public static List<CapaDatos.Prestamo> Listar()
        {
            using(var db = new FinancieraEntities())
            {
                return db.Prestamo.ToList();
            }
        }
    }
}
