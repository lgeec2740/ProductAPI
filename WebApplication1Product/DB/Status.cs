using System;
using System.Collections.Generic;

namespace WebApplication1Product.DB;

public partial class Status
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
