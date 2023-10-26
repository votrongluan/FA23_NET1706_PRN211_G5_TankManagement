using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Manufactory
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int LocationId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual ICollection<Tank> Tanks { get; set; } = new List<Tank>();
}
