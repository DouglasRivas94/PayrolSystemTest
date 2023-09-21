using PayableInterfaceTest;
//create a List<IPayable> and initilize it whit four objects of classes that implement interface IPayable

var payableObjects = new List<IPayable>()
{
    new Invoice("01234", "seat", 2, 375.00M),
    new Invoice("56789", "tire", 4, 79.95M),
    new SalariedEmployee("Daniela", "XAji", "111-11-1111", 800.00M),
    new SalariedEmployee("Elizabet", "Bae", "222-22-2222", 1200.00M)
};

Console.WriteLine("Invoice and employees processed " + "Polymorphically:\n");

foreach (var payable in payableObjects)
{
    Console.WriteLine($"{payable}");
    Console.WriteLine($"pAYMENT DUE: {payable.GetPaymentAmount():C}\n");
}