using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class TblAuditSetupHead
{
    public long AuditSetupId { get; set; }

    public string StrAuditSetupCode { get; set; } = null!;

    public long IntAccountId { get; set; }

    public long IntBranchId { get; set; }

    public long IntOfficeId { get; set; }

    public long IntWarehouseId { get; set; }

    public DateTime DteCreatedDate { get; set; }

    public DateTime DteStartDate { get; set; }

    public DateTime DteEndDate { get; set; }

    public long IntActionBy { get; set; }

    public bool IsComplete { get; set; }

    public bool IsApprove { get; set; }

    public bool IsActive { get; set; }

    public bool IsReject { get; set; }

    public long IntApproveBy { get; set; }

    public string? StrRemarks { get; set; }

    public long IntRejectBy { get; set; }

    public DateTime DteActionDateTime { get; set; }

    public DateTime DteServerDateTime { get; set; }
}
