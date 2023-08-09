using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class ItemSellingPriceHeader
{
    public long HeaderId { get; set; }

    public string TransactionCode { get; set; } = null!;

    public DateTime TransactionDate { get; set; }

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long OfficeId { get; set; }

    public long WarehouseId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? Remarks { get; set; }

    public bool IsActive { get; set; }

    public long ActionById { get; set; }

    public DateTime LastActionDatetime { get; set; }

    public bool IsApprove { get; set; }

    public long ApproveById { get; set; }

    public DateTime? ApproveDatetime { get; set; }

    public long CancelById { get; set; }

    public DateTime? CancelDatetime { get; set; }

    public bool IsPercent { get; set; }

    public decimal AmountOrPercent { get; set; }

    public bool? IsMarkUp { get; set; }

    public long SupplierId { get; set; }
}
