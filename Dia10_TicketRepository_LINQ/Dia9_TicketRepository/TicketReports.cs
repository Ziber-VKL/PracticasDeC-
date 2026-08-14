using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia10_TicketRepository;

internal class TicketReports
{
    private List<Ticket> tickets;

    public TicketReports(List<Ticket> tickets)
    {
        this.tickets= tickets;
    }
    public List<Ticket> GetCriticalTickets()
    {
        return tickets.Where(ticket => ticket.Priority == Priority.Critical).ToList();
    }

    public List<Ticket> GetOpenTickets()
    {
        return tickets.Where(ticket => ticket.Status == Status.Open).ToList();
    }

    public List <Ticket> GetTicketByUser(User user)
    {
        return tickets.Where(ticket => ticket.CreatedBy == user).ToList();
    }

    //public List<Ticket> GetTickerPerPriority()
    //{
    //    return tickets.GroupBy(ticket => ticket.Priority);
    //}

    public List<Ticket> GetTicketByDay()
    {
        return tickets.OrderBy(ticket => ticket.CreatedDate).ToList();
    }

    public bool AllTicketAreClosed()
    {
        return tickets.All(ticket => ticket.Status == Status.Closed);
    }

    public bool AnyCriticalTicket()
    {
        return tickets.Any(ticket => ticket.Priority == Priority.Critical);
    }

    public List<User> GetDistinctUsers()
    {
        return tickets.Select(ticket => ticket.CreatedBy).DistinctBy(user => user.Id).ToList();
    }


}
