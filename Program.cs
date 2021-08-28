using System;

namespace ArrayOfObjectDemo
{
    class Employee
    {
        internal int empID;
        internal string empName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int nEmp;
            Console.WriteLine("Enter Number of Employees");
            nEmp = Convert.ToInt32(Console.ReadLine());
            Employee[] e = new Employee[nEmp];

            for (int i = 0; i < nEmp; i++)
            {
                e[i] = new Employee();
                Console.WriteLine("Enter Details of Employee {0} :", i);
                Console.Write("Enter Employee ID: ");
                e[i].empID = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Employee Name: ");
                e[i].empName = Console.ReadLine();
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("ID\tName");
            for (int i = 0; i < nEmp; i++)
                Console.WriteLine("{0}\t{1}", e[i].empID, e[i].empName);
        }
    }
}
