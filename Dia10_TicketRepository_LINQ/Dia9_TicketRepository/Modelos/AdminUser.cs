using Dia10_TicketRepository.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia10_TicketRepository.Modelos;

public class AdminUser : User
{
    public AdminUser(int id, string name, string email, Role role) : base(id, name, email, role)
    {

    }
}
