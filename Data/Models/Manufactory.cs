using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Manufactory
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? LocationId { get; set; }

    public bool? IsDelete { get; set; }

    public virtual Location Location { get; set; }

    public virtual ICollection<Tank> Tanks { get; set; } = new List<Tank>();
}
