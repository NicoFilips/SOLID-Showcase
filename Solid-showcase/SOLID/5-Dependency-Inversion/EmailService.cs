namespace Solid_showcase.SOLID._5_Dependency_Inversion;

// EmailService implements IMessageService
public class EmailService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending email: {message}");
    }
}