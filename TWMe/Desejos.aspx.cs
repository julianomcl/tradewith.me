using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TWMe.DAO;
using TWMe.Models;

namespace TWMe
{
    public partial class Desejos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Title = "Desejos";
        }

        protected void AddProduto(object sender, EventArgs e)
        {
            /*
            DesejoDAO desejoDAO = new DesejoDAO();
            Desejo desejo = new Desejo();
            desejo.Id_Rotulo = Convert.ToInt32(Rotulo.SelectedValue.ToString());
            if (Session["IdUsuario"] != null)
                desejo.Id_Usuario = Convert.ToInt32(Session["IdUsuario"].ToString());
            else
                desejo.Id_Usuario = 0;
                */
        }
    }
}