using System;

namespace EmployeePayrollSystem
{
    // Interface
    interface IPayroll
    {
        void CalculateSalary();
    }

    // Base Class
    class Employee
    {
        public int EmployeeID;
        public string Name;
        public double OneDaySalary;
        public int DaysWorked;

        // Take input from user
        public void GetDetails()
        {
            Console.Write("Enter Employee ID: ");
            EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter One Day Salary: ");
            OneDaySalary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Days Worked: ");
            DaysWorked = Convert.ToInt32(Console.ReadLine());
        }
    }

    // Derived Class
    class Worker : Employee, IPayroll
    {
        public void CalculateSalary()
        {
            double TotalSalary = OneDaySalary * DaysWorked;

            Console.WriteLine("\n------ Employee Payroll ------");
            Console.WriteLine("Employee ID   : " + EmployeeID);
            Console.WriteLine("Employee Name : " + Name);
            Console.WriteLine("One Day Salary: " + OneDaySalary);
            Console.WriteLine("Days Worked   : " + DaysWorked);
            Console.WriteLine("Total Salary  : " + TotalSalary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism
            IPayroll payroll = new Worker();

            Worker emp = (Worker)payroll;

            emp.GetDetails();
            payroll.CalculateSalary();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}           