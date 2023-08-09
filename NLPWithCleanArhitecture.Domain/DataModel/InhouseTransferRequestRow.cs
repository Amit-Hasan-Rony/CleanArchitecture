using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class InhouseTransferRequestRow
{
    public long RowId { get; set; }

    public long RequestId { get; set; }

    public long ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string Barcode { get; set; } = null!;

    public long UomId { get; set; }

    public string UomName { get; set; } = null!;

    public decimal RequestQty { get; set; }

    public decimal ApproveQty { get; set; }

    public decimal TransferQty { get; set; }

    public decimal? RestQty { get; set; }

    public decimal TransferInQty { get; set; }

    public bool IsActive { get; set; }
}
