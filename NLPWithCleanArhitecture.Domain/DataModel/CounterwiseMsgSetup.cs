using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class CounterwiseMsgSetup
{
    public long CounterMsgId { get; set; }

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public string Message { get; set; } = null!;

    public long ActionById { get; set; }

    public string ActionByName { get; set; } = null!;

    public DateTime LastActionDatetime { get; set; }

    public bool IsActive { get; set; }
}
