using MyLibrary;

Secretary Maria = new Secretary();
Maria.Name = "Maria";
Mannager Pedro = new Mannager();
Pedro.Name = "Pedro";
Developer Miguel  = new Developer(); 

WriteEmployeeInfo (Pedro);
WriteEmployeeInfo (Miguel);
WriteEmployeeInfo(Maria);

void WriteEmployeeInfo(Employee employee)
{
    Console.WriteLine( $"{employee.Name}: {employee.CalculateMonthlyPayment()}");
}