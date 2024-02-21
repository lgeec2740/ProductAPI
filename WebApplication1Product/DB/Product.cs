using System;
using System.Collections.Generic;

namespace WebApplication1Product.DB;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? IdStatus { get; set; }

    public virtual Status? IdStatusNavigation { get; set; }
}
