using System;
using System.Collections.Generic;

namespace CustomerWebsite.Models;

public partial class SemiTransportation
{
    public int? ProductId { get; set; }

    public int? TransportId { get; set; }

    public int SemiTransId { get; set; }

    public virtual SemiSelfProduct? Product { get; set; }

    public virtual Transportation? Transport { get; set; }
}
