using System;
using System.Collections.Generic;

namespace Pr3SP.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly Birth { get; set; }

    public string? Patronymic { get; set; }
}
