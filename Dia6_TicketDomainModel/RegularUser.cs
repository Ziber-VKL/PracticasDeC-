using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6_TicketDomainModel;

public class RegularUser : User
{
    public RegularUser(int id, string name) : base(id,name)
    {

    }

    public override void ShowPermissions()
    {
        Console.WriteLine($"{Name}");
        Console.WriteLine("-Create Ticket");
        Console.WriteLine("-View Own Tickets");
    }
}
