using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    public abstract class Numeros : IOperaciones
    {
        private decimal a, b;

        public Numeros(decimal N1, decimal N2)
        {
            a = N1;
            b = N2;

        }
        public decimal A
        {
            get { return a; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(A)} must be >= 0");
                }
                a = value;
            }
        }
        public decimal B
        {
            get { return b; }
            set
            {
                if (b < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(B)} must be >= 0");
                }
                b = value;
            }
        }
        public override string ToString() => $"{A} {B}\n";

        public abstract decimal Respuesta();
        public decimal GetOperacion() => Respuesta();
    }
}
