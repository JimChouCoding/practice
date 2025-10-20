using System;
using System.Collections.Generic;

namespace CustomerWebsite.Models;

public partial class ProductsPromotion
{
    public int? PromoId { get; set; }

    public int? ProductId { get; set; }

    public int ProductPromoId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Promotion? Promo { get; set; }
}
