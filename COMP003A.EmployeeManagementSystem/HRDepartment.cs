namespace COMP003A.EmployeeManagementSystem;

/// <summary>
/// Human Resources department.
/// </summary>
public class HRDepartment : Department, IHRDepartmentOperations
{
    public HRDepartment()
    {
        DepartmentName = "Human Resources";
    }
    
    // overrides GetDepartmentDetails() with a description
    public override string GetDepartmentDetails()
    {
        return "Handles employee relations and recruitment. ";
    }

    public void Operate()
    {
        Console.WriteLine("Performing HR operations... ");
    }
}

/// <summary>
/// Human Resources Department operations interface.
/// </summary>
public interface IHRDepartmentOperations
{
    void Operate();
}