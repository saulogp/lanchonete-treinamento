﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lanchonete.Proxy
{
    public class Proxy
    {
        public const String INSERT = "INSERT INTO TBLog (dateInformation, descricao) VALUES (GETDATE(), '{0}')";
        public const String SELECT = "SELECT dateInformation, descricao FROM TBLog";

        public DateTime DateInformation { get; set; }
        public string Descricao { get; set; }
    }
}