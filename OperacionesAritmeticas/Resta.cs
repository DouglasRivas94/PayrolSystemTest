﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    internal class Resta : IOperaciones
    {
        public decimal GetOperacion { get; set; }

        public void calculo(decimal a, decimal b)
        {
            GetOperacion = a -b;
        }
    }
}
