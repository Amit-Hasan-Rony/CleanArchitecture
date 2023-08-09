using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class InhouseTransferReceivedRow
{
    public long RowId { get; set; }

    public long HeaderId { get; set; }

    public long ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public decimal ReceivedQty { get; set; }
}
