using System;
using System.Collections.Generic;

namespace Data.Models;

public partial class Role
{
    public int Id { get; set; }

    public string Description { get; set; }

    public bool? IsDelete { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
