using System;
using System.Collections.Generic;

namespace BlazorTest.Entities;

public partial class Contact
{
    public Guid Id { get; set; }

    public string? TelegramId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
