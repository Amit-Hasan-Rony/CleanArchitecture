using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class TblAuditSetupRow
{
    public long RowId { get; set; }

    public long AuditSetupId { get; set; }

    public long IntCategoryId { get; set; }

    public string StrCategoryCode { get; set; } = null!;

    public string StrCategoryName { get; set; } = null!;

    public long IntSubCategoryId { get; set; }

    public string StrSubCategoryName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime DteActionDateTime { get; set; }

    public DateTime DteServerDateTime { get; set; }
}
