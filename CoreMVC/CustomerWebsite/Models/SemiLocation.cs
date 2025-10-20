using System;
using System.Collections.Generic;

namespace CustomerWebsite.Models;

public partial class SemiLocation
{
    public int? ProductId { get; set; }

    public int? LocationId { get; set; }

    public int SemiLocationId { get; set; }

    public virtual Location? Location { get; set; }

    public virtual SemiSelfProduct? Product { get; set; }
}
