using System;
using System.Collections.Generic;

namespace BlazorTest.Entities;

public partial class User
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }
}
