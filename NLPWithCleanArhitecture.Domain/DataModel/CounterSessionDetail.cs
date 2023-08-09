using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class CounterSessionDetail
{
    public long CounterSessionDetailsId { get; set; }

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long CounterId { get; set; }

    public long CounterSessionId { get; set; }

    public string CurrencyName { get; set; } = null!;

    public long CurrencyOpeningCount { get; set; }

    public long CurrencyClosingCount { get; set; }

    public long ActionById { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastActionDatetime { get; set; }

    public DateTime ServerDatetime { get; set; }
}
