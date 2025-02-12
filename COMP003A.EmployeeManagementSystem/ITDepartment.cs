namespace COMP003A.EmployeeManagementSystem;

/// <summary>
/// Information Technology department.
/// </summary>
public class ITDepartment : Department, IITDepartmentOperations
{
    public ITDepartment()
    {
        DepartmentName = "Information Technology";
    }
    
    // overrides GetDepartmentDetails() with a description
    public override string GetDepartmentDetails()
    {
        return "Manages technical resources and infrastructure. ";
    }

    public void Operate()
    {
        Console.WriteLine("Performing IT operations... ");
    }
}

/// <summary>
/// Information Technology Department operations interface.
/// </summary>
public interface IITDepartmentOperations
{
    void Operate();
}