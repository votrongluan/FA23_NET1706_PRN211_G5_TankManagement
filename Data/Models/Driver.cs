using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Driver
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int UnitId { get; set; }

    public virtual ICollection<TankDriver> TankDrivers { get; set; } = new List<TankDriver>();

    public virtual Unit Unit { get; set; } = null!;
}
