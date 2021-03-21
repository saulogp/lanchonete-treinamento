using Lanchonete.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete.Data
{
    interface ILogDB
    {
        void Insert(string log);
        List<Log> Select();
    }
}
