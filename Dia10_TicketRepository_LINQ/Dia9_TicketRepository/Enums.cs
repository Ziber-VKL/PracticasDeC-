using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia10_TicketRepository;

   public enum Role
    {
        Admin,
        User
    }

    public enum Priority
    { 
        Low,
        Medium,
        High,
        Critical
    }

    public enum Status
    {
        Open,
        Assigned,
        InProgress,
        Resolved,
        Closed
    }


