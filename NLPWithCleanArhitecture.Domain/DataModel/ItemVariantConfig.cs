using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class ItemVariantConfig
{
    public long ItemVariantConfigId { get; set; }

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long VariantId { get; set; }

    public string VariantName { get; set; } = null!;

    public string VariantValue { get; set; } = null!;

    public bool IsActive { get; set; }

    public long ActionById { get; set; }

    public DateTime LastActionDatetime { get; set; }
}
