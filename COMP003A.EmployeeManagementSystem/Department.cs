namespace COMP003A.EmployeeManagementSystem;

/// <summary>
/// Department abstract class. 
/// </summary>
public abstract class Department
{
    // auto-implemented property 
    public string DepartmentName { get; set; }

    /// <summary>
    /// Abstract method that returns department details.
    /// </summary>
    public abstract string GetDepartmentDetails();

    /// <summary>
    /// Prints the department name and details. 
    /// </summary>
    public void PrintDepartmentInfo()
    {
        Console.WriteLine($"Department: {DepartmentName}\nDetails: {GetDepartmentDetails()}");
    }
}