﻿using System;
using System.Collections.Generic;

namespace SchoolProjectMVC.Data;

public partial class Lecture
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;
}