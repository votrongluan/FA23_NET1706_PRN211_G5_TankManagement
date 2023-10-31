using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class TankDriver
{
    public int Id { get; set; }

    public int? TankId { get; set; }

    public int? DriverId { get; set; }

    public bool? IsDelete { get; set; }

    public virtual Driver Driver { get; set; }

    public virtual Tank Tank { get; set; }
}
