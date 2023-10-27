using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class History
{
    public int Id { get; set; }

    public int? FromUnitId { get; set; }

    public int? ToUnitId { get; set; }

    public int? TankId { get; set; }

    public DateTime? Date { get; set; }

    public virtual Unit FromUnit { get; set; }

    public virtual Tank Tank { get; set; }

    public virtual Unit ToUnit { get; set; }
}
