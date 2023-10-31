using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Model
{
    public int Id { get; set; }

    public int? Weight { get; set; }

    public int? MaxSpeed { get; set; }

    public string Detail { get; set; }

    public int? MaxNoDriver { get; set; }

    public int? AmmoId { get; set; }

    public int? Price { get; set; }

    public string Name { get; set; }

    public int? ShootingRange { get; set; }

    public bool? IsDelete { get; set; }

    public virtual Ammo Ammo { get; set; }

    public virtual ICollection<Tank> Tanks { get; set; } = new List<Tank>();
}
