using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class User
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public int? RoleId { get; set; }

    public virtual Role Role { get; set; }

    public virtual ICollection<UnitManager> UnitManagers { get; set; } = new List<UnitManager>();
}
