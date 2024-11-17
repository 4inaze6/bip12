using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bip12.Models;

public partial class User
{
    [Key]
    public int UserId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;
}
