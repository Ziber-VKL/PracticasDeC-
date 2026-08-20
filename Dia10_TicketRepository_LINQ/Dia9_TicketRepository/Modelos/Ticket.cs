using Dia10_TicketRepository.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia10_TicketRepository.Modelos;

internal class Ticket
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public Priority Priority { get; set; }
    public Status Status { get; set; }
    public User CreatedBy { get; set; }

    public Ticket(int id,string title,string description,Priority priority,User createdBy)
    {
        Id = id;
        Title = title;
        Description = description;
        Priority = priority;
        Status = Status.Open;
        CreatedDate = DateTime.Now;
        CreatedBy = createdBy;
    }



    public override string ToString()
    {
        return $"{Id}|{Title}|{Description}|{CreatedDate}|{Priority}|{Status}|{CreatedBy}";
    }

}
