using OperacionesAritmeticas;

var operacionesAritmeticas = new List<IOperaciones>()
{
    new Resta(12, 11),
    new Suma(13, 12)
};

foreach (var operacion in operacionesAritmeticas)
{
    Console.WriteLine(operacion);
}