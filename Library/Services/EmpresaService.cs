﻿using Library.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public class EmpresaService
    {
        public EmpresaRepository oEmpresaRepository { get; set; }

        public EmpresaService()
        {
            oEmpresaRepository = new EmpresaRepository();
        }
    }
}
