using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class ItemVariant
{
    public long ItemVariantId { get; set; }

    public string ItemVariantName { get; set; } = null!;

    public bool IsActive { get; set; }
}
