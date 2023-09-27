using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritmeticas
{
    public class Suma : IOperaciones
    {
        public decimal GetOperacion { get; set; }

        public void calculo(decimal a, decimal b)
        {
            GetOperacion = a + b;
        }

        public void mostrar()
        {
            Console.WriteLine("El resultado de la suma es: {0}", GetOperacion);
        }
    }
}
