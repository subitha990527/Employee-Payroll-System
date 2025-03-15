using System;
using System.Collections.Generic;

namespace PayrollSystem
{
    public class BaseEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty; // Default initialization
        public decimal BasicPay { get; set; }
        public decimal Allowances { get; set; }

        public virtual decimal CalculateSalary() => BasicPay + Allowances;
    }

    public class Manager : BaseEmployee
    {
        public override decimal CalculateSalary() => BasicPay + Allowances; // 10% deduction
    }

    public class Developer : BaseEmployee
    {
        public override decimal CalculateSalary() => BasicPay + Allowances; // 5% deduction
    }

    public class Intern : BaseEmployee
    {
        public override decimal CalculateSalary() => BasicPay + Allowances; // No deduction
    }

    public class PayrollSystem
    {
        private List<BaseEmployee> employees = new List<BaseEmployee>();

        public void AddEmployee(BaseEmployee employee) => employees.Add(employee);
        public void DisplayEmployees()
        {
            foreach (var e in employees)
                Console.WriteLine($"ID: {e.ID}, Name: {e.Name}, Role: {e.GetType().Name}, Salary: {e.CalculateSalary()}");
        }
        public void CalculateTotalPayroll()
        {
            decimal total = 0;
            employees.ForEach(e => total += e.CalculateSalary());
            Console.WriteLine($"Total Payroll: {total}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PayrollSystem payroll = new PayrollSystem();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\n1. Add Employee\n2. Display Employees\n3. Calculate Total Payroll\n4. Exit");
                Console.Write("Choose an option: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input, try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter ID: ");
                        if (!int.TryParse(Console.ReadLine(), out int id))
                        {
                            Console.WriteLine("Invalid ID.");
                            continue;
                        }
                        Console.Write("Enter Name: ");
                        string? name = Console.ReadLine();
                        Console.Write("Enter Role (Manager/Developer/Intern): ");
                        string? role = Console.ReadLine();
                        Console.Write("Enter Basic Pay: ");
                        if (!decimal.TryParse(Console.ReadLine(), out decimal basicPay))
                        {
                            Console.WriteLine("Invalid Basic Pay.");
                            continue;
                        }
                        Console.Write("Enter Allowances: ");
                        if (!decimal.TryParse(Console.ReadLine(), out decimal allowances))
                        {
                            Console.WriteLine("Invalid Allowances.");
                            continue;
                        }

                        BaseEmployee? employee = role?.ToLower() switch
                        {
                            "manager" => new Manager { ID = id, Name = name ?? "Unknown", BasicPay = basicPay, Allowances = allowances },
                            "developer" => new Developer { ID = id, Name = name ?? "Unknown", BasicPay = basicPay, Allowances = allowances },
                            "intern" => new Intern { ID = id, Name = name ?? "Unknown", BasicPay = basicPay, Allowances = allowances },
                            _ => null
                        };

                        if (employee == null)
                        {
                            Console.WriteLine("Invalid role.");
                            continue;
                        }
                        payroll.AddEmployee(employee);
                        Console.WriteLine("Employee added successfully!");
                        break;

                    case 2:
                        payroll.DisplayEmployees();
                        break;

                    case 3:
                        payroll.CalculateTotalPayroll();
                        break;

                    case 4:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
