﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginFormAspCore.Models;

public partial class UserId
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = null!;

    [Required]
    public string Gender { get; set; } = null!;

    [Required]
    public int? Age { get; set; }

    [Required]
    public string Email { get; set; } = null!;

    [DataType(DataType.Password)]
    [Required]
    public string Password { get; set; } = null!;
}
