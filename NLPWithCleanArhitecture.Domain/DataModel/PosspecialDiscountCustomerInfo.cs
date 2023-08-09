using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class PosspecialDiscountCustomerInfo
{
    public long IntRowId { get; set; }

    public long IntSpecialDiscountId { get; set; }

    public long IntCustomerId { get; set; }

    public string StrCustomerName { get; set; } = null!;

    public bool? IsActive { get; set; }
}
