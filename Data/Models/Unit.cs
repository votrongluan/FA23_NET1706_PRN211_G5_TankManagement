using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Unit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Location { get; set; } = null!;

    public virtual ICollection<Driver> Drivers { get; set; } = new List<Driver>();

    public virtual ICollection<History> HistoryFromUnits { get; set; } = new List<History>();

    public virtual ICollection<History> HistoryToUnits { get; set; } = new List<History>();

    public virtual ICollection<Tank> Tanks { get; set; } = new List<Tank>();
}
