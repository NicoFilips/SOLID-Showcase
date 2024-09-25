namespace Solid_showcase.Solid._1_Single_Responsibility.BadExample;

// Employee class with multiple responsibilities
public class Employee
{
    public string EmployeeId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public void SaveEmployee(Employee employee)
    {
        // Code to save employee details to a database
    }

    public void GenerateEmailToEmployee(Employee employee)
    {
        // Code to send an email to the employee
    }
}