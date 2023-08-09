using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class CounterSession
{
    public long CounterSessionId { get; set; }

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long OfficeId { get; set; }

    public long CounterId { get; set; }

    public string CounterCode { get; set; } = null!;

    public decimal OpeningCash { get; set; }

    public decimal? ClosingCash { get; set; }

    public string? OpeningNote { get; set; }

    public DateTime StartDatetime { get; set; }

    public long TotalInvoice { get; set; }

    public decimal TotalSales { get; set; }

    public decimal CardAmountCollection { get; set; }

    public decimal MfsamountCollection { get; set; }

    public decimal CashAmountCollection { get; set; }

    public DateTime? ClosingDatetime { get; set; }

    public long ActionById { get; set; }

    public bool IsActive { get; set; }

    public DateTime LastActionDatetime { get; set; }

    public DateTime ServerDatetime { get; set; }

    public string? ClosingNote { get; set; }
}
