using System;
using System.Collections.Generic;

namespace NLPWithCleanArhitecture.Domain.DataModel;

public partial class PossalesDeliveryHeaderTemp
{
    public long SalesOrderId { get; set; }

    public string SalesOrderCode { get; set; } = null!;

    public long? CustomerOrderId { get; set; }

    public long AccountId { get; set; }

    public string AccountName { get; set; } = null!;

    public long BranchId { get; set; }

    public string BranchName { get; set; } = null!;

    public long CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? Phone { get; set; }

    public string? ChallanNo { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime DeliveryDate { get; set; }

    public string Remarks { get; set; } = null!;

    public long PaymentTypeId { get; set; }

    public string PaymentTypeName { get; set; } = null!;

    public decimal TotalQuantity { get; set; }

    public decimal ItemTotalAmount { get; set; }

    public decimal NetDiscount { get; set; }

    public decimal OthersCost { get; set; }

    public decimal NetAmount { get; set; }

    public decimal TotalLineDiscount { get; set; }

    public decimal HeaderDiscount { get; set; }

    public decimal HeaderDiscountPercentage { get; set; }

    public decimal ReceiveAmount { get; set; }

    public decimal PendingAmount { get; set; }

    public decimal? ReturnAmount { get; set; }

    public decimal InterestRate { get; set; }

    public decimal NetAmountWithInterest { get; set; }

    public long TotalNoOfInstallment { get; set; }

    public DateTime InstallmentStartDate { get; set; }

    public string InstallmentType { get; set; } = null!;

    public decimal AmountPerInstallment { get; set; }

    public long SalesForceId { get; set; }

    public string SalesForceName { get; set; } = null!;

    public long ActionById { get; set; }

    public string ActionByName { get; set; } = null!;

    public DateTime ActionTime { get; set; }

    public bool? IsPosSales { get; set; }

    public bool IsActive { get; set; }

    public string? SalesOrReturn { get; set; }

    public decimal? AdvanceBalanceAdjust { get; set; }

    public decimal? CustomerNetAmount { get; set; }

    public bool? IsComplete { get; set; }

    public int? SalesTypeId { get; set; }

    public string? SalesTypeName { get; set; }

    public long? SalesOrderRefId { get; set; }

    public string? Narration { get; set; }

    public long? SmsTransactionId { get; set; }

    public string? AnonymousAddress { get; set; }

    public decimal? TotalSd { get; set; }

    public decimal? TotalVat { get; set; }

    public bool IsBillCreated { get; set; }

    public decimal? DiscoundItemTotalPrice { get; set; }

    public decimal? OfferItemTotal { get; set; }

    public long? WalletId { get; set; }

    public decimal? ComissionPercentage { get; set; }

    public bool? IsInclusive { get; set; }

    public long OfficeId { get; set; }

    public string? CustomerPo { get; set; }

    public string? BillNo { get; set; }

    public long? ShippingAddressId { get; set; }

    public string? ShippingAddressName { get; set; }

    public string ShippingContactPerson { get; set; } = null!;

    public bool IsConfirmed { get; set; }

    public bool IsApprove { get; set; }

    public string? ProjectName { get; set; }

    public long FreeTypeId { get; set; }

    public string? FreeTypeName { get; set; }

    public long JobOrderId { get; set; }

    public long VoucherId { get; set; }

    public bool? Isexchange { get; set; }

    public long? HeaderDiscountId { get; set; }

    public long? CounterId { get; set; }

    public bool? IsProcess { get; set; }

    public decimal? CashPayment { get; set; }

    public decimal? Points { get; set; }

    public bool? IsOnline { get; set; }
}
