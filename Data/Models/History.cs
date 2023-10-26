using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class History
{
    public int Id { get; set; }

    public int FromUnitId { get; set; }

    public int ToUnitId { get; set; }

    public int TankId { get; set; }

    public virtual Unit FromUnit { get; set; } = null!;

    public virtual Tank Tank { get; set; } = null!;

    public virtual Unit ToUnit { get; set; } = null!;
}
