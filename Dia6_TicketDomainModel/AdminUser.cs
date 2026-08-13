using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia6_TicketDomainModel;

public class AdminUser : User
{
    public AdminUser(int id, string name) : base(id, name)
    {

    }

    public override void ShowPermissions()
    {
        Console.WriteLine($"{Name}");
        Console.WriteLine("-Create Users");
        Console.WriteLine("-Delete Tickets");
        Console.WriteLine("-Assign Tickets");
        Console.WriteLine("-Close Tickets");

    }
}
