using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia9_TicketRepository;

public class AdminUser : User
{
    public AdminUser(int id, string name, string email, Role role) : base(id, name, email, role)
    {

    }
}
