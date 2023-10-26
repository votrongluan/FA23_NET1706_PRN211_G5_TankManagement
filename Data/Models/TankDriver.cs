using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TankDriver
{
    public int Id { get; set; }

    public int TankId { get; set; }

    public int DriverId { get; set; }

    public virtual Driver Driver { get; set; } = null!;

    public virtual Tank Tank { get; set; } = null!;
}
