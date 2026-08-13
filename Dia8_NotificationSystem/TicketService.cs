using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia8_NotificationSystem;

public class TicketService
{
    private readonly INotificationService notification;
    public TicketService(INotificationService notification)
    {
        this.notification = notification;
    }

    public void CreateTicket(int numeroDeTicket)
    {
        Console.WriteLine("Creando Ticket.");
        notification.Send($"Ticket #{numeroDeTicket} creado");
    }

}