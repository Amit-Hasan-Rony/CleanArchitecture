using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class PosspecialDiscount
{
    public long HeaderId { get; set; }

    public string OfferName { get; set; } = null!;

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long OfficeId { get; set; }

    public long WarehouseId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? Remarks { get; set; }

    /// <summary>
    /// DiscountType 1 = Percentage,2=Amount
    /// </summary>
    public long DiscountType { get; set; }

    public decimal Value { get; set; }

    public bool IsActive { get; set; }

    public long ActionById { get; set; }

    public DateTime LastActionDatetime { get; set; }

    public decimal MinAmount { get; set; }

    public decimal MaxAmount { get; set; }

    public string? CustomerGroupIds { get; set; }

    public bool? IsOpenDiscount { get; set; }
}
