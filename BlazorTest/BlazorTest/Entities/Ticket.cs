using System;
using System.Collections.Generic;

namespace BlazorTest.Entities;

public partial class Ticket
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Number { get; set; }

    public string? TelegramId { get; set; }

    public Guid GameId { get; set; }

    public virtual Game Game { get; set; } = null!;
}
