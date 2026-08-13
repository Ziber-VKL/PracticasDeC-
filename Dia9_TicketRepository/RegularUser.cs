using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia9_TicketRepository;

public class RegularUser : User
{
    public RegularUser(int id, string name, string email, Role role) : base(id, name, email, role)
    {

    }
}
