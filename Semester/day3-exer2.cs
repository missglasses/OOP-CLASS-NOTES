using System;

//Inheritance – Employee Management System

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Employee: {Name}, Salary: {Salary}");
    }
}

// TODO: Create Manager class (inherits Employee)
// Add Bonus property and CalculateTotalCompensation() method
    class Manager: Employee{
        public double Bonus  { get; set; }
        
        public void CalculateTotalCompensation(){
              Console.WriteLine($"Total Compensation = {Salary+Bonus}");
        }
    }

// TODO: Create Developer class (inherits Employee)
// Add ProgrammingLanguage property and Work() method
class Developer : Employee {
    
    public string ProgrammingLanguage { get; set; }
    
    public void Work(){
         Console.WriteLine($"{Name} is coding in {ProgrammingLanguage}.");
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        // Input for Manager
        Console.Write("Enter Manager Name: ");
        string managerName = Console.ReadLine();

        Console.Write("Enter Manager Salary: ");
        double managerSalary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Manager Bonus: ");
        double managerBonus = Convert.ToDouble(Console.ReadLine());

        // TODO: Create Manager object and call methods
        Manager mgr = new Manager();
        mgr.Name="Eric";
        mgr.Salary=10000;
        mgr.Bonus=managerBonus;
        mgr.DisplayInfo();
        mgr.CalculateTotalCompensation();

        Console.WriteLine();

        // Input for Developer
        Console.Write("Enter Developer Name: ");
        string developerName = Console.ReadLine();

        Console.Write("Enter Developer Salary: ");
        double developerSalary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Programming Language: ");
        string devLanguage = Console.ReadLine();

        // TODO: Create Developer object and call methods
        Developer dev = new Developer();
        dev.Name="Mark";
        dev.Salary=15000;
        dev.ProgrammingLanguage="C#";
        dev.DisplayInfo();
        dev.Work();
    }
}
