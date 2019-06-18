using Junio17b.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Junio17b.dal
{
    public class ProductosDAL
    {
        public static List<Productos> ListarTodo()
        {
            var listado=new List<Productos>();

            using(var modelo=new Model1()) { 
                // LINQ
                // LEER : grupo.entidad.(comandos linq).ToList()
                // LEER UN ELEMENTO: First() FirstOrDefault()

                listado=modelo.Productos
                    .OrderBy(p => p.Nombre) // donde p corresponde a una fila
                    //.Where(p => p.Nombre=="Cocacola")
                    .ToList(); // finalmente traer el listado
                // select * from productos where nombre='cocacola' order by nombre

            }

            return listado;
        }  // fin listartodo
    }
}