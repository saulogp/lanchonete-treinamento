using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanchonete.Model
{
    public class Pizza : Refeicao
    {
        public const String Insert = "insert into refeicao (descricao, valor) values ('{0}', {1})";
        public const String InsertFK = "insert into pizza (idrefeicao) select id from refeicao where descricao = '{0}' and valor = {1}";
        public const String Select = "select r.id, r.descricao, r.valor from refeicao r join pizza p on r.id = p.idrefeicao";


    }
}