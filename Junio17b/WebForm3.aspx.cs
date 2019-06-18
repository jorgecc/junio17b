using Junio17b.dal;
using Junio17b.ef;
using Junio17b.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Junio17b
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var nuevoPais=new Paises();
            nuevoPais=PaisesSrv.Factory(TextBox1,TextBox2);
            PaisesDAL.Insertar(nuevoPais);
        }
    }
}