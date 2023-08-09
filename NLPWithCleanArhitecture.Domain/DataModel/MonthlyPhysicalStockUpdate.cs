using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class MonthlyPhysicalStockUpdate
{
    public long StockUpdateId { get; set; }

    public long AccountId { get; set; }

    public long BranchId { get; set; }

    public long OfficeId { get; set; }

    public string AutoCode { get; set; } = null!;

    public long WarehouseId { get; set; }

    public decimal Price { get; set; }

    public long ItemId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public long SoftwareStock { get; set; }

    public long PhysicalStock { get; set; }

    public long ChangeStock { get; set; }

    public bool IsActive { get; set; }

    public long ActionBy { get; set; }

    public DateTime LastActionDatetime { get; set; }

    public DateTime ServerDatetime { get; set; }
}
