using Lanchonete.Model;
using Lanchonete.Data;
using System;

namespace Lanchonete
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulaTabelaPizza();
            PopulaTabelaLog();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            var pizza = new Pizza() { Descricao = txtDesc.Text, Valor = decimal.Parse(txtValor.Text) };
            var logDB = new LogDB();

            if (new PizzaDB().Insert(pizza))
            {
                logDB.Insert("Inserido com sucesso");
                lblMSG.Text = "Top";
            }
            else
            {
                logDB.Insert("Elemento não inserido");
            }
            PopulaTabelaPizza();
            PopulaTabelaLog();
            
        }


        private void PopulaTabelaPizza()
        {
            gvPizza.DataSource = new PizzaDB().Select();

            gvPizza.DataBind();
        }
        private void PopulaTabelaLog()
        {
            gvLog.DataSource = new LogDB().Select();

            gvLog.DataBind();
        }

    }
}