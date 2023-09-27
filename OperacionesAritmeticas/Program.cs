using OperacionesAritmeticas;

int opcion = 0;
decimal v1 = 0, v2 = 0;
IOperaciones operacion = new Suma();

while(opcion != 5)
{
    Console.WriteLine("1-Suma\n" + "2-Resta\n" + "3-Multiplicacion\n" + "4-division\n" + "5-Salir");
    Console.WriteLine("Digite la opcion que desee");
    opcion = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite el primer valor");
    v1 = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("Digite el segundo valor");
    v2 = Convert.ToDecimal(Console.ReadLine());

    //Polimorfismo
    if (opcion == 1)
        operacion = new Suma();
    if (opcion == 2)
        operacion = new Resta();
    if (opcion == 3)
        operacion = new Multiplicacion();
    if (opcion == 4)
        operacion = new Division();

    operacion.calculo(v1, v2);
    operacion.mostrar();
}