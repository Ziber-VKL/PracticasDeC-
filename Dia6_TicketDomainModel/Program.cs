using static System.Console;
namespace Dia6_TicketDomainModel;

internal class Program
{
    static void Main(string[] args)
    {
        User admin = new User(1, "Miguel Admin", "MigueAdmin@gmail.com", Role.Admin);
        User usuario = new User(2,"Marco Usuario", "MarcoUsuario@gmail.com", Role.User);

        Ticket ticket1 = new Ticket(1,"Compu no prende","La maquina no prende", Priority.High,admin);
        Ticket ticket2 = new Ticket(2,"Resetear password", "Se necesita cambiar la password", Priority.Medium, usuario);
        Ticket ticket3 = new Ticket(3,"El server no responde", "El servidor dejo de responder", Priority.Critical, admin);


        WriteLine("Usuarios");
        WriteLine(admin);
        WriteLine(usuario);

        WriteLine("Tickets");
        WriteLine(ticket1);
        WriteLine(ticket2);
        WriteLine(ticket3);
    }
}
