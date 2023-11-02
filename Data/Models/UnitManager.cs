using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class UnitManager
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? UnitId { get; set; }

    public bool? IsDelete { get; set; }

    public virtual Unit Unit { get; set; }

    public virtual User User { get; set; }
}
