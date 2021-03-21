using Lanchonete.Model;
using Lanchonete.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lanchonete
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulaTabela();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            var pizza = new Pizza() { Descricao = txtDesc.Text, Valor = decimal.Parse(txtValor.Text) };

            if (new PizzaDB().Insert(pizza)) lblMSG.Text = "Top";
            PopulaTabela();
        }


        private void PopulaTabela()
        {
            gvPizza.DataSource = new PizzaDB().Select();

            gvPizza.DataBind();
        }

    }
}