using System;
using System.Collections.Generic;

namespace CustomerWebsite.Models;

public partial class ProductsRestaurant
{
    public int? ProductId { get; set; }

    public int? RestaurantId { get; set; }

    public int ProductRestaurantId { get; set; }

    public int? OrderIndex { get; set; }

    public string? MealType { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Restaurant? Restaurant { get; set; }
}
