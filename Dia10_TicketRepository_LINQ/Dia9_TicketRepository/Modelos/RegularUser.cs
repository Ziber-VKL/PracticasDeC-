using Dia10_TicketRepository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia10_TicketRepository.Modelos;

public class RegularUser : User
{
    public RegularUser(int id, string name, string email, Role role) : base(id, name, email, role)
    {

    }
}
