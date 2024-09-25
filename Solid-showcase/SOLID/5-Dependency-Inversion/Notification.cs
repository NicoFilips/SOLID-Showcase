﻿namespace Solid_showcase.SOLID._5_Dependency_Inversion;

// Notification depends on abstraction IMessageService
public class Notification
{
    private readonly IMessageService _messageService;

    public Notification(IMessageService messageService)
    {
        _messageService = messageService;
    }

    public void Notify(string message)
    {
        _messageService.SendMessage(message);
    }
}