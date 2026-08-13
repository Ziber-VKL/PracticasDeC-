using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia8_NotificationSystem;

public class EmailNotificationService : INotificationService
{
    public void Send(string message)
    {
        string email = ("hola@gmail.com");
        string subject = ("Ticket Creado");
        string body = message;

        Console.WriteLine("Sending email...");
        Console.WriteLine($"To: {email}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Body: {body}");
        Console.WriteLine("Email Sent");
    }
}
