using System;
using System.Collections.Generic;

namespace BlazorTest.Entities;

public partial class Game
{
    public Guid Id { get; set; }

    public string? Text { get; set; }

    public int Price { get; set; }

    public int TicketCount { get; set; }

    public bool Active { get; set; }

    public DateTime StartDate { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
