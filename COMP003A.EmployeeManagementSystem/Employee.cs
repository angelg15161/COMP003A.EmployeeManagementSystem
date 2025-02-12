namespace COMP003A.EmployeeManagementSystem;

/// <summary>
/// Employee class with encapsulation. 
/// </summary>
public class Employee
{
    // fields 
    private string _employeeId;
    private string _firstName;
    private string _middleName = string.Empty;
    private string _lastName;
    private double _salary;
    
    // properties 
    public string EmployeeId
    {
        get { return _employeeId; }
        private set { _employeeId = value; }
    }

    public string FirstName
    {
        get { return _firstName; }
        set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("First name can't be empty."); _firstName = value; }
    }

    public string MiddleName
    {
        get { return _middleName; }
        set { _middleName = value ?? string.Empty; }
    }

    public string LastName
    {
        get { return _lastName; }
        set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Last name can't be empty."); _lastName = value; }
    }

    public double Salary
    {
        get { return _salary; }
        set { if (value < 0) throw new ArgumentException("Salary can't be negative."); _salary = value; }
    }
    
    // constructors
    public Employee(string employeeId, string firstName, string lastName, double salary, string middleName = "")
    {
        EmployeeId = employeeId;
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
        Salary = salary;
    }

    /// <summary>
    /// Prints the employee's full name.
    /// </summary>
    public void PrintFullName()
    {
        if (string.IsNullOrWhiteSpace(MiddleName))
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
        else
        {
            Console.WriteLine($"{FirstName} {MiddleName} {LastName}");
        }
    }

    /// <summary>
    /// Prints the employee's information.
    /// </summary>
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee ID: {EmployeeId}");
        Console.Write("Employee Name: ");
        PrintFullName();
        Console.WriteLine($"Salary: {Salary:C}");
    }
}