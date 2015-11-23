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
    public partial class Produtos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Title = "Meus Produtos";

        }

        protected void AddProduto(object sender, EventArgs e)
        {
            /*ProdutoDAO prodDAO = new ProdutoDAO();
            Produto prod = new Produto();
            prod.Data_Inclusao = DateTime.Now;
            prod.Descricao = Descricao.Text;
            prod.Id_Rotulo = Convert.ToInt32(RotuloTxt.Text);
            if (Session["IdUsuario"] != null)
                prod.Id_Usuario = Convert.ToInt32(Session["IdUsuario"].ToString());
            else
                prod.Id_Usuario = 0;
            if (Imagem != null)
                prod.Imagem = GetRouteUrl(Imagem);*/
        }
    }
}