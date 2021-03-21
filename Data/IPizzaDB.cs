using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lanchonete.Model;

namespace Lanchonete.Data
{
    public interface IPizzaDB
    {
        bool Insert(Pizza pizza);
        List<Pizza> Select();
    }
}
