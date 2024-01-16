using System;

public class Employee
{
    public string Name { get; set; }
    public decimal BasicSalary { get; set; }
    public decimal HRA { get { return BasicSalary * 0.15M; } }
    public decimal DA { get { return BasicSalary * 0.10M; } }
    public decimal Tax { get { return GrossPay * 0.08M; } }
    public decimal GrossPay { get { return BasicSalary + HRA + DA; } }
    public decimal NetPay { get { return GrossPay - Tax; } }

    public Employee(string name, decimal basicSalary)
    {
        Name = name;
        BasicSalary = basicSalary;
    }

        public void Display()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Basic Salary: {BasicSalary}");
        Console.WriteLine($"HRA: {HRA}");
        Console.WriteLine($"DA: {DA}");
        Console.WriteLine($"Gross Pay: {GrossPay}");
        Console.WriteLine($"Tax: {Tax}");
        Console.WriteLine($"Net Pay: {NetPay}");
    }
}

class Program
{
    static void Main()
    {
        Employee employee = new Employee("M V Jagannatha Reddy", 100000);
        employee.Display();
    }
}
