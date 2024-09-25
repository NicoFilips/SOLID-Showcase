namespace Solid_showcase.SOLID._5_Dependency_Inversion.BadExample;

public class Notification
{
    private EmailService _emailService = new EmailService();
    
    public void Notify(string message)
    {
        _emailService.SendEmail(message);
    }
}