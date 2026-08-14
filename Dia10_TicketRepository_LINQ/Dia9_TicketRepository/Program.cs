using System;
using System.Collections.Generic;

namespace Dia10_TicketRepository;

internal class Program
{
    static void Main(string[] args)
    {
        User admin = new User( 1,"Miguel Admin","MigueAdmin@gmail.com",Role.Admin);
        User usuario1 = new User(2, "Marco Usuario", "MarcoUsuario@gmail.com", Role.User);
        User usuario2 = new User(3, "Carlos Usuario", "CarlosUsuario@gmail.com", Role.User);
        User usuario3 = new User(4, "Ana Usuario", "AnaUsuario@gmail.com", Role.User);

        TicketManager ticketManager = new TicketManager();
        ticketManager.AddTicket("Computer does not turn on","The computer does not start",Priority.Critical,usuario1);
        ticketManager.AddTicket("Printer does not work","The printer is not printing",Priority.High,usuario2);
        ticketManager.AddTicket("Password reset","User forgot password",Priority.Low,usuario3);
        ticketManager.AddTicket("Keyboard problem", "Keyboard is not responding", Priority.Medium, usuario2); 
        ticketManager.AddTicket("Server is down", "Main server is unavailable", Priority.Critical, usuario3); 
        ticketManager.AddTicket("Mouse problem", "Mouse is not working", Priority.Low, usuario1); 
        ticketManager.AddTicket("Email problem", "Cannot send emails", Priority.High, usuario2); 
        ticketManager.AddTicket("Software installation", "Need new software installed", Priority.Medium, usuario3); 
        ticketManager.AddTicket("Monitor problem", "Monitor has no image", Priority.High, usuario1); 
        ticketManager.AddTicket("Database error", "Database connection failed", Priority.Critical, usuario2); 
        ticketManager.AddTicket("Slow computer", "Computer is running slowly", Priority.Medium, usuario3); 
        ticketManager.AddTicket("VPN problem", "VPN cannot connect", Priority.High, usuario1); 
        ticketManager.AddTicket("Office application error", "Application crashes when opening", Priority.Medium, usuario2); 
        ticketManager.AddTicket("Phone problem", "Office phone does not work", Priority.Low, usuario3); 
        ticketManager.AddTicket("Security alert", "Possible security issue", Priority.Critical, usuario1); 
        ticketManager.AddTicket("Printer paper problem", "Printer is out of paper", Priority.Low, usuario2); 
        ticketManager.AddTicket("Login problem", "Cannot log into the system", Priority.High, usuario3);
        ticketManager.AddTicket("Application update", "Application needs an update", Priority.Medium, usuario1);
        ticketManager.AddTicket("Backup problem","Backup did not complete",Priority.Critical,usuario2);

        ticketManager.GetTicketById(2).Status = Status.Closed;
        ticketManager.GetTicketById(3).Status = Status.Resolved;
        ticketManager.GetTicketById(4).Status = Status.Assigned;
        ticketManager.GetTicketById(5).Status = Status.InProgress;
        ticketManager.GetTicketById(6).Status = Status.Closed;
        ticketManager.GetTicketById(8).Status = Status.Resolved;
        ticketManager.GetTicketById(10).Status = Status.Closed;
        ticketManager.GetTicketById(12).Status = Status.Assigned;
        ticketManager.GetTicketById(14).Status = Status.Closed;
        ticketManager.GetTicketById(15).Status = Status.Resolved;
        ticketManager.GetTicketById(17).Status = Status.Closed;
        ticketManager.GetTicketById(18).Status = Status.InProgress;

        List<Ticket> tickets = ticketManager.GetAllTickets();
        TicketReports reports = new TicketReports(tickets);

        Console.WriteLine("Critical Tickets");

        var criticalTickets = reports.GetCriticalTickets();

        foreach (Ticket ticket in criticalTickets)
        {
            Console.WriteLine(ticket);
        }

        Console.WriteLine("Open Tickets");

        var openTickets = reports.GetOpenTickets();

        foreach (Ticket ticket in openTickets)
        {
            Console.WriteLine(ticket);
        }

        Console.WriteLine("Ticket By User");

        var userTickets = reports.GetTicketByUser(usuario1);

        foreach (Ticket ticket in userTickets)
        {
            Console.WriteLine(ticket);
        }

        Console.WriteLine("Ticker Order By Day");

        var orderedTickets = reports.GetTicketByDay();

        foreach (Ticket ticket in orderedTickets)
        {
            Console.WriteLine(
                $"{ticket.CreatedDate} - {ticket.Title}"
            );
        }

        Console.WriteLine("Are All Tickets Closed?");

        bool allClosed = reports.AllTicketAreClosed();

        Console.WriteLine(allClosed);

        Console.WriteLine("Any Critical Tickets");

        bool anyCritical = reports.AnyCriticalTicket();

        Console.WriteLine(anyCritical);

        Console.WriteLine("Distinc Users");

        var distinctUsers = reports.GetDistinctUsers();

        foreach (User user in distinctUsers)
        {
            Console.WriteLine(user);
        }

    }
}
