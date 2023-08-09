using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class TblPointRedemptionRow
{
    public long PointRedemptionRowId { get; set; }

    public long PointRedemptionId { get; set; }

    public string? RedeemCode { get; set; }

    public long? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerMobile { get; set; }

    public decimal? GainedPoint { get; set; }

    public decimal? RedeemPoint { get; set; }

    public decimal? Amount { get; set; }

    public decimal? RemainingPoint { get; set; }

    public DateTime ActivationDate { get; set; }

    public DateTime ExpiryDate { get; set; }

    public long IntActionBy { get; set; }

    public bool IsUsed { get; set; }

    public DateTime LastActonDateTime { get; set; }

    public DateTime ServerDateTime { get; set; }

    public bool? IsActive { get; set; }

    public string? Reason { get; set; }
}
