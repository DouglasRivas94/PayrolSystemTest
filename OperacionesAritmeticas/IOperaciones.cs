using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    public interface IOperaciones
    {
        decimal GetOperacion { get; set; }

        void calculo(decimal a, decimal b);

        void mostrar()
        {
            Console.WriteLine("El resultado es {0}", GetOperacion);
        }
    }
}
