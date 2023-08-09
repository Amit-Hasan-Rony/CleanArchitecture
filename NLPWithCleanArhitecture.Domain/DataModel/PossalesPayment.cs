using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class PossalesPayment
{
    public long PossalesPaymentId { get; set; }

    public long SalesDeliveryId { get; set; }

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long OfficeId { get; set; }

    public long WalletId { get; set; }

    public decimal CollectionAmount { get; set; }

    public DateTime TransactionDate { get; set; }

    public bool IsActive { get; set; }

    public long ActionById { get; set; }

    public DateTime LastActionDatetime { get; set; }

    public DateTime ServerDatetime { get; set; }

    public string? ReferanceNo { get; set; }
}
