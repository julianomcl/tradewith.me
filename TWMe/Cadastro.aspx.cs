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
    public partial class Cadastr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUp(object sender, EventArgs e)
        {
            Session["Username"] = Email.Text;
            Usuario usu = new Usuario();
            usu.Nome = Nome.Text;
            usu.Email = Email.Text;
            usu.Senha = Password.Text;
            if(DataNasc != null)
                usu.DataNascimento = Convert.ToDateTime(DataNasc.Text);
            if(Foto != null)
                usu.Foto = GetRouteUrl(Foto);
            usu.Facebook = Facebook.Text;
            UsuarioDAO usuDAO = new UsuarioDAO();
            usuDAO.Ins(usu);
            List<Usuario> listUsu = usuDAO.Get();
            Session["IdUsuario"] = (listUsu.Find(x => x.Email == Email.Text)).Id_Usuario;
            Response.Redirect("Default.aspx");
        }
    }
}