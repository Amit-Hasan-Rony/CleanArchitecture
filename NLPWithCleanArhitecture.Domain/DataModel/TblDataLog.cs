using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class TblDataLog
{
    public long LogId { get; set; }

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long? OfficeId { get; set; }

    public long? CounterId { get; set; }

    public long? ServerUserId { get; set; }

    public string? StrLogMessage { get; set; }

    public string? StrEntityData { get; set; }

    public string? LogType { get; set; }

    public DateTime? LastActionDateTime { get; set; }

    public DateTime? ServerDateTime { get; set; }

    public byte? IsSync { get; set; }
}
