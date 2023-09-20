using PayrolSystemTest;
//Employee hierarchy test app

// Create derived class object
var SalariedEmployee = new SalariedEmployee("Juan", "Gonzales", "111-11-1111", 800.00M);
var HourlyEmployee = new HourlyEmployee("Karen", "Chavez", "222-22-2222", 16.75M, 40.00M);
var ComisionEmployee = new ComisionEmployee("Susana", "Aguilar", "333-33-3333", 10000.00M, .06M);
var BasePlusComisionEmployee = new BasePlusComisionEmployee("Roberto", "Xeras", "444-44-4444", 5000.00M, .04M, 300.00M);

Console.WriteLine("Employee Processed Individually: \n");
Console.WriteLine($"{SalariedEmployee}\nearned: " + $"{SalariedEmployee.Earnings():C}\n");
Console.WriteLine($"{HourlyEmployee}\nearned: " + $"{HourlyEmployee.Earnings():C}\n");
Console.WriteLine($"{ComisionEmployee}\nearned: " + $"{ComisionEmployee.Earnings():C}\n");
Console.WriteLine($"{BasePlusComisionEmployee}\nearned: " + $"{BasePlusComisionEmployee.Earnings():C}\n");

//create List<Employee> and initialize with employee objects
var employees = new List<Employee>() {SalariedEmployee, HourlyEmployee, ComisionEmployee, BasePlusComisionEmployee };

Console.WriteLine("Employees processed polymorphically:\n");

//generically process each element in employee
foreach(var currentEmployee in employees)
{
    Console.WriteLine(currentEmployee); //invokes toString

    if (currentEmployee is BasePlusComisionEmployee)
    {
        var employee = (BasePlusComisionEmployee)currentEmployee;

        employee.BaseSalary *= 1.10M;

        Console.WriteLine("New base salary with 10% increase is : " + $"{employee.BaseSalary:C}");
    }
    Console.WriteLine($"earned: {currentEmployee.Earnings():C}n");
}

for(int i = 0; i < employees.Count; i++)
{
    Console.WriteLine($"Employee{i} is a {employees[i].GetType()}");
}