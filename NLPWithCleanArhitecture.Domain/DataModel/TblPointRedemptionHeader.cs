using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class TblPointRedemptionHeader
{
    public long PointRedemptionId { get; set; }

    public string? PointRedemptionCode { get; set; }

    public string? PointRedemptionName { get; set; }

    public long? AccountId { get; set; }

    public long? BranchId { get; set; }

    public long? OfficeId { get; set; }

    public long? WarehouseId { get; set; }

    public long? PointRedemptionType { get; set; }

    public string? PointRedemptionTypeName { get; set; }

    public decimal? RedeemPercentage { get; set; }

    public string? PointRedemptionCodePrefix { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public bool IsApprove { get; set; }

    public long IntActionBy { get; set; }

    public long? IntApproveBy { get; set; }

    public DateTime LastActonDateTime { get; set; }

    public DateTime ServerDateTime { get; set; }

    public bool? IsActive { get; set; }

    public string? Remarks { get; set; }

    public bool IsReject { get; set; }

    public long IntRejectBy { get; set; }
}
