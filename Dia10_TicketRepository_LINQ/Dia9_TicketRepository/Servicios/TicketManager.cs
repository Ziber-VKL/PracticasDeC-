using Dia10_TicketRepository.Enums;
using Dia10_TicketRepository.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia10_TicketRepository.Servicios;

internal class TicketManager
{

    private List<Ticket> ticketRepo;
    private Dictionary<int, Ticket> ticketDic;
    private Queue<Ticket> ticketQueue;

    public TicketManager()
    {
        ticketRepo = new List<Ticket>();
        ticketDic = new Dictionary<int, Ticket>();
        ticketQueue= new Queue<Ticket>();
    }

    public int AddTicket(string title, string description, Priority priority, User createdBy)
    {
        
        int newTicketId = 0;

            
        if (ticketRepo.Count > 0)
        {
            newTicketId = ticketDic.Keys.Max() + 1;
        }
        else
        {
            newTicketId = 1;
        }

        Ticket newTicket = new Ticket(newTicketId, title, description, priority, createdBy);
        ticketRepo.Add(newTicket);
        ticketDic[newTicketId] = newTicket;
        ticketQueue.Enqueue(newTicket);

        return newTicketId;
    }


    public Ticket? GetTicketById(int ticketId)
    {
        bool getTicketResult = ticketDic.TryGetValue(ticketId, out Ticket newTicket);

        if (getTicketResult == false)
        {
            return null;
        }
        return newTicket;
    }

    public List<Ticket> GetAllTickets()
    {
        return ticketRepo;


    }


    public Ticket AssginTicket(User user)
    {
        if (user.Role != Role.Admin)
        {
            throw new Exception($"The user: {user.Name} does not have admin permission ");
        }

        return ticketQueue.Dequeue();
    }

    public Ticket? RemoveTicket(int ticketId)
    {
        Ticket? ticket = GetTicketById(ticketId);

        if(ticket == null)
        {
            return null;
        }
        ticketRepo.Remove(ticket);
        ticketDic.Remove(ticketId);
        return ticket;
    }
}
