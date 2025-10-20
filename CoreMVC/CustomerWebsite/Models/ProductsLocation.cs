using System;
using System.Collections.Generic;

namespace CustomerWebsite.Models;

public partial class ProductsLocation
{
    public int? ProductId { get; set; }

    public int? LocationId { get; set; }

    public int ProductLocationId { get; set; }

    public int? DayNumber { get; set; }

    public int? OrderIndex { get; set; }

    public virtual Location? Location { get; set; }

    public virtual Product? Product { get; set; }
}
