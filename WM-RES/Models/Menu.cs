using System;
using System.Collections.Generic;

namespace WM_RES.Models;

public partial class Menu
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public decimal? Price { get; set; }
}
