using System.Net;

namespace Dia9_TicketRepository;

internal class Program
{
    static void Main(string[] args)
    {
        TicketManager ticketManager = new TicketManager();

        User admin = new User(1, "Miguel Admin", "MigueAdmin@gmail.com", Role.Admin);
        User usuario = new User(2, "Marco Usuario", "MarcoUsuario@gmail.com", Role.User);

        int ticketId = ticketManager.AddTicket("Compu no prende","La maquina no prende", Priority.High,admin);

        Console.WriteLine($"Se ha creado un nuevo Ticket con la id: {ticketId}");


        ticketId = ticketManager.AddTicket("La impresora no imprime", "No salen las hojas", Priority.Low, usuario);

        Console.WriteLine($"Se ha creado un nuevo Ticket con la id: {ticketId}");



        var resultado = ticketManager.AssginTicket(admin);

        //var reultado2 = ticketManager.RemoveTicket(2);

        var resultado3 = ticketManager.GetTicketById(1);

        var resultado4 = ticketManager.GetAllTickets();
    }
}
