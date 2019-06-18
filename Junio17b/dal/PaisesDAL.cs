using Junio17b.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio17b.dal
{
    public class PaisesDAL
    {
        public static List<Paises> ListarTodo()
        {
            var listado=new List<Paises>();

            using(var modelo=new Model1()) { 
                listado=modelo.Paises.ToList();
            }

            return listado;
        }  // fin listartodo

        public static void Insertar(Paises obj)
        {
            using(var modelo=new Model1())
            {
                modelo.Paises.Add(obj);
                modelo.SaveChanges(); // guardar todos los cambios pendientes
            }
        }
    }
}