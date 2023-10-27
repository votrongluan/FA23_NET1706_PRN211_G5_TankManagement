using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Tank
{
    public int Id { get; set; }

    public int? ModelId { get; set; }

    public int? ManufactoryId { get; set; }

    public int? UnitId { get; set; }

    public virtual ICollection<History> Histories { get; set; } = new List<History>();

    public virtual Manufactory Manufactory { get; set; }

    public virtual Model Model { get; set; }

    public virtual ICollection<TankDriver> TankDrivers { get; set; } = new List<TankDriver>();

    public virtual Unit Unit { get; set; }
}
