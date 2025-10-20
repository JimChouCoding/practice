using System;
using System.Collections.Generic;

namespace CustomerWebsite.Models;

public partial class ProductsHotel
{
    public int? ProductId { get; set; }

    public int? HotelId { get; set; }

    public int ProductHotelId { get; set; }

    public int? OrderIndex { get; set; }

    public virtual Hotel? Hotel { get; set; }

    public virtual Product? Product { get; set; }
}
