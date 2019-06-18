using Junio17b.ef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Junio17b.servicio
{
    public class PaisesSrv
    {
        public static Paises Factory(TextBox txtId,TextBox txtNombre)
        {
            var nuevoPais=new Paises();
            nuevoPais.PaisId= Convert.ToInt32(txtId.Text); // no olvidar Convert.ToInt32()
            nuevoPais.Nombre = txtNombre.Text;
            return nuevoPais;
        }
    }
}