using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    internal class Resta : Numeros
    {
        public Resta(decimal N1, decimal N2) : base(N1, N2)
        {
        }

        public override decimal Respuesta() => A - B;
    }
}
