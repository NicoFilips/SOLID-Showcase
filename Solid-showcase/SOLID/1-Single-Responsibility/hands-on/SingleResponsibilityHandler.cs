using Solid_showcase.Solid._1_Single_Responsibility;

namespace Solid_showcase.Solid._1_Single_Responsibility.hands_on;
    
public class SingleResponsibilityHandler
{
    public void DemonstrateSingleResponsibility()
    {
        // Create an employee
        Employee employee = new Employee
        {
            EmployeeId = "E123",
            Name = "John Doe",
            Email = "john.doe@example.com"
        };

        // Save the employee using EmployeeRepository
        EmployeeRepository employeeRepository = new EmployeeRepository();
        employeeRepository.SaveEmployee(employee);

        // Notify the employee using EmployeeNotifier
        EmployeeNotifier employeeNotifier = new EmployeeNotifier();
        employeeNotifier.GenerateEmailToEmployee(employee);
    }
}