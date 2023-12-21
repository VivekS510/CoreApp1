using System;
using System.Collections.Generic;

namespace CoreApp1.Models;

public partial class UserRegister
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime CreateOn { get; set; }

    public DateTime? LastLoggedOn { get; set; }
}
