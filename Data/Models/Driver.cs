using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Driver
{
    public int Id { get; set; }

    public string IdCard { get; set; }

    public string Name { get; set; }

    public string Phone { get; set; }

    public int? UnitId { get; set; }

    public bool? IsDelete { get; set; }

    public virtual ICollection<TankDriver> TankDrivers { get; set; } = new List<TankDriver>();

    public virtual Unit Unit { get; set; }
}
