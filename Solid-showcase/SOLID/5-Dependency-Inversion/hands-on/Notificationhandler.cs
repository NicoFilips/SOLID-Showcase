namespace Solid_showcase.SOLID._5_Dependency_Inversion.hands_on;

public class NotificationHandler
{
    private IMessageService _emailService = new EmailService();
    private Notification _notification;

    public NotificationHandler()
    {
        _notification = new Notification(_emailService);
    }

    public void SendNotification(string message)
    {
        _notification.Notify(message);
    }
}