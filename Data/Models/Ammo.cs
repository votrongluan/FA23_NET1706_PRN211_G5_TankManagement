using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Ammo
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? Price { get; set; }

    public int? Weight { get; set; }

    public bool? IsDelete { get; set; }

    public virtual ICollection<Model> Models { get; set; } = new List<Model>();
}
