/*
    Author: Angel Gomez
    Course: COMP-003A
    Faculty: Jonathan Cruz
    Purpose: Employee management system demonstrating OOP principles in C#
*/ 
namespace COMP003A.EmployeeManagementSystem;

class Program
{
    static void Main(string[] args) 
    {
        while (true)
        {
            try
            {
                // employee user input with try parse for invalid input 
                Console.Write("Enter your Employee ID: ");
                string employeeId = Console.ReadLine();
                Console.Write("Enter your First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Enter your Middle Name or press 'Enter' to skip: ");
                string middleName = Console.ReadLine();
                Console.Write("Enter your Last Name: ");
                string lastName = Console.ReadLine();
                Console.Write("Enter your Salary: ");
                double salary = double.Parse(Console.ReadLine());

                // employee instance 
                Employee employee = new Employee(employeeId, firstName, lastName, salary, middleName);
                Console.WriteLine("Employee Created Successfully! \n");
                employee.DisplayEmployeeInfo(); // prints the employee's information 

                // department instances 
                HRDepartment hr = new HRDepartment();
                ITDepartment it = new ITDepartment();

                // prints department information 
                Console.WriteLine(" ");
                hr.PrintDepartmentInfo();
                hr.Operate();

                Console.WriteLine(" ");
                it.PrintDepartmentInfo();
                it.Operate();
                break;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\n{ex.Message}\nPlease re-enter information correctly.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n{e.Message}\nPlease re-enter information correctly.\n");
            }
        }
    }
}
