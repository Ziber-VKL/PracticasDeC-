namespace Dia8_NotificationSystem;

internal class Program
{
    static void Main(string[] args)
    {
        INotificationService notification = new EmailNotificationService();

        TicketService ticketService = new TicketService(notification);

        ticketService.CreateTicket(12);
    }
}
