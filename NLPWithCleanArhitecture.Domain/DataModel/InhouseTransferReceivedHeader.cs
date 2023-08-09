using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class InhouseTransferReceivedHeader
{
    public long TransferInId { get; set; }

    public string TransferCode { get; set; } = null!;

    public long TransferOutId { get; set; }

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long SendingOfficeId { get; set; }

    public long SendingWarehouseId { get; set; }

    public long RequestingOfficeId { get; set; }

    public long RequestingWarehouseId { get; set; }

    public decimal TotalInQty { get; set; }

    public DateTime TransferDate { get; set; }

    public long ActionById { get; set; }

    public string ActionByName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime LastActionDatetime { get; set; }

    public DateTime ServerDatetime { get; set; }
}
