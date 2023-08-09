using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class ItemSellingPriceRowTemp
{
    public long RowId { get; set; }

    public long HeaderId { get; set; }

    public long ItemId { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal OldPrice { get; set; }

    public decimal NewPrice { get; set; }

    public decimal Qty { get; set; }

    public bool IsActive { get; set; }

    public long ActionById { get; set; }

    public DateTime LastActionDatetime { get; set; }

    public long BatchId { get; set; }

    public decimal? AltQty { get; set; }
}
