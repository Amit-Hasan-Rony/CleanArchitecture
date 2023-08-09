using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class Poscounter
{
    public long CounterId { get; set; }

    public string CounterName { get; set; } = null!;

    public string CounterCode { get; set; } = null!;

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long OfficeId { get; set; }

    public long WarehouseId { get; set; }

    public DateTime CounterOpeningDate { get; set; }

    public DateTime? CounterClosingDate { get; set; }

    public long ActionById { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastActionDatetime { get; set; }

    public DateTime ServerDatetime { get; set; }

    public string UserId { get; set; } = null!;

    public long MessageId { get; set; }
}
