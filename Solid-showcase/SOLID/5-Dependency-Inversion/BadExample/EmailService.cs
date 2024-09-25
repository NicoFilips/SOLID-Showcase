namespace Solid_showcase.SOLID._5_Dependency_Inversion.BadExample;

public class EmailService
{
    public void SendEmail(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}