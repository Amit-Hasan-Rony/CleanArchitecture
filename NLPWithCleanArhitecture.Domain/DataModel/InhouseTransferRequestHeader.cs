using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class InhouseTransferRequestHeader
{
    public long RequestId { get; set; }

    public string RequestCode { get; set; } = null!;

    public long RequestTypeId { get; set; }

    public string RequestTypeName { get; set; } = null!;

    public long Grnid { get; set; }

    public string? Grncode { get; set; }

    public long CurrencyId { get; set; }

    public string? CurrencyName { get; set; }

    public decimal ExchangeRate { get; set; }

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long RequestingOfficeId { get; set; }

    public long RequestingWarehouseId { get; set; }

    public long SendingOfficeId { get; set; }

    public long SendingWarehouseId { get; set; }

    public decimal TotalRequestQty { get; set; }

    public decimal TotalApproveQty { get; set; }

    public decimal TotalOutQty { get; set; }

    public decimal TotalInQty { get; set; }

    public long PartnerId { get; set; }

    public string PartnerName { get; set; } = null!;

    public string Purpose { get; set; } = null!;

    public string? DeliveryAddress { get; set; }

    public DateTime RequestDate { get; set; }

    public DateTime? ExpectedDate { get; set; }

    public bool IsApprove { get; set; }

    public long ApproveById { get; set; }

    public DateTime? ApproveDate { get; set; }

    public bool IsComplete { get; set; }

    public string? Remarks { get; set; }

    public bool IsActive { get; set; }

    public long ActionById { get; set; }

    public string ActionByName { get; set; } = null!;

    public DateTime LastActionDatetime { get; set; }

    public DateTime ServerDatetime { get; set; }

    public string Review { get; set; } = null!;
}
