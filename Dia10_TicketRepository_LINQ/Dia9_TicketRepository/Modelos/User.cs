using Dia10_TicketRepository.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Dia10_TicketRepository.Modelos;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public Role Role { get; set; }

    public User(int id, string name, string email, Role role)
    {
        Id = id;
        Name = name;
        Email = email;
        Role = role;
    }

    public override string ToString()
    {
        return $"{Id}|{Name}|{Email}|{Role}";
    }
}

