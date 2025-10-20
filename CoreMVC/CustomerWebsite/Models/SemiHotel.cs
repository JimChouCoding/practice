using System;
using System.Collections.Generic;

namespace CustomerWebsite.Models;

public partial class SemiHotel
{
    public int? ProductId { get; set; }

    public int? HotelId { get; set; }

    public int SemiHotelId { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual SemiSelfProduct? Product { get; set; }
}
