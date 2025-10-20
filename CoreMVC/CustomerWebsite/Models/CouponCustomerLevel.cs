using System;
using System.Collections.Generic;

namespace CustomerWebsite.Models;

public partial class CouponCustomerLevel
{
    public int CouponLevelId { get; set; }

    public int? CouponId { get; set; }

    public int? CustomerLevel { get; set; }

    public virtual Coupon? Coupon { get; set; }
}
