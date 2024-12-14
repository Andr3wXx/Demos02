using System.Xml.Linq;
using MyLibrary;

Employee Maria = new Secretary();
Maria.Name = "Maria";
Employee Pedro = new Mannager();
Pedro.Name = "Pedro";
Employee Miguel  = new Developer();
Miguel.Name = "Miguel";
Developer Miguel = new Developer();
Console.WriteLine($"DIas: {Miguel.GetPaymentDays()}");

WriteEmployeeInfo (Pedro);
WriteEmployeeInfo (Miguel);
WriteEmployeeInfo(Maria);

void WriteEmployeeInfo(Employee employee)
{
    Console.WriteLine( $"{employee.Name}: {employee.CalculateMonthlyPayment()}");
    Console.WriteLine( $"Days: {employee.GetPaymentDays()}");
}