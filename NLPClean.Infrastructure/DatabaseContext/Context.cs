using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NLPWithCleanArhitecture.Domain.DataModel;

namespace NLPWithCleanArhitecture.Domain;

public partial class Context : DbContext
{
    public Context()
    {
    }

    public Context(DbContextOptions<Context> options)
        : base(options)
    {
    }

    public virtual DbSet<CounterSession> CounterSessions { get; set; }

    public virtual DbSet<CounterSessionDetail> CounterSessionDetails { get; set; }

    public virtual DbSet<CounterwiseMsgSetup> CounterwiseMsgSetups { get; set; }

    public virtual DbSet<InhouseTransferReceivedHeader> InhouseTransferReceivedHeaders { get; set; }

    public virtual DbSet<InhouseTransferReceivedRow> InhouseTransferReceivedRows { get; set; }

    public virtual DbSet<InhouseTransferRequestHeader> InhouseTransferRequestHeaders { get; set; }

    public virtual DbSet<InhouseTransferRequestRow> InhouseTransferRequestRows { get; set; }

    public virtual DbSet<ItemSellingPriceHeader> ItemSellingPriceHeaders { get; set; }

    public virtual DbSet<ItemSellingPriceHeaderTemp> ItemSellingPriceHeaderTemps { get; set; }

    public virtual DbSet<ItemSellingPriceRow> ItemSellingPriceRows { get; set; }

    public virtual DbSet<ItemSellingPriceRowMarkupDown> ItemSellingPriceRowMarkupDowns { get; set; }

    public virtual DbSet<ItemSellingPriceRowTemp> ItemSellingPriceRowTemps { get; set; }

    public virtual DbSet<ItemVariant> ItemVariants { get; set; }

    public virtual DbSet<ItemVariantConfig> ItemVariantConfigs { get; set; }

    public virtual DbSet<MonthlyPhysicalStockUpdate> MonthlyPhysicalStockUpdates { get; set; }

    public virtual DbSet<Poscounter> Poscounters { get; set; }

    public virtual DbSet<PossalesDeliveryHeader> PossalesDeliveryHeaders { get; set; }

    public virtual DbSet<PossalesDeliveryHeaderTemp> PossalesDeliveryHeaderTemps { get; set; }

    public virtual DbSet<PossalesDeliveryLine> PossalesDeliveryLines { get; set; }

    public virtual DbSet<PossalesDeliveryLineTemp> PossalesDeliveryLineTemps { get; set; }

    public virtual DbSet<PossalesPayment> PossalesPayments { get; set; }

    public virtual DbSet<PosspecialDiscount> PosspecialDiscounts { get; set; }

    public virtual DbSet<PosspecialDiscountCustomerInfo> PosspecialDiscountCustomerInfos { get; set; }

    public virtual DbSet<TblAuditSetupHead> TblAuditSetupHeads { get; set; }

    public virtual DbSet<TblAuditSetupRow> TblAuditSetupRows { get; set; }

    public virtual DbSet<TblDataLog> TblDataLogs { get; set; }

    public virtual DbSet<TblPointRedemptionHeader> TblPointRedemptionHeaders { get; set; }

    public virtual DbSet<TblPointRedemptionRow> TblPointRedemptionRows { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=10.209.99.144;Initial Catalog=PrinceBazar;User ID=smeapp;Password=sds#dt454sesa0wdnp@1vpo#98;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CounterSession>(entity =>
        {
            entity.ToTable("CounterSession", "pos");

            entity.Property(e => e.CardAmountCollection).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CashAmountCollection).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ClosingCash).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ClosingDatetime).HasColumnType("datetime");
            entity.Property(e => e.ClosingNote).HasMaxLength(500);
            entity.Property(e => e.CounterCode).HasMaxLength(50);
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.MfsamountCollection)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("MFSAmountCollection");
            entity.Property(e => e.OpeningCash).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.OpeningNote).HasMaxLength(200);
            entity.Property(e => e.ServerDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StartDatetime).HasColumnType("datetime");
            entity.Property(e => e.TotalSales).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<CounterSessionDetail>(entity =>
        {
            entity.HasKey(e => e.CounterSessionDetailsId);

            entity.ToTable("CounterSessionDetails", "pos");

            entity.Property(e => e.CurrencyName).HasMaxLength(50);
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.ServerDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CounterwiseMsgSetup>(entity =>
        {
            entity.HasKey(e => e.CounterMsgId);

            entity.ToTable("CounterwiseMsgSetup", "pos");

            entity.Property(e => e.ActionByName).HasMaxLength(200);
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.Message).HasMaxLength(500);
        });

        modelBuilder.Entity<InhouseTransferReceivedHeader>(entity =>
        {
            entity.HasKey(e => e.TransferInId);

            entity.ToTable("InhouseTransferReceivedHeader", "pos");

            entity.Property(e => e.ActionByName).HasMaxLength(200);
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.ServerDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TotalInQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TransferCode).HasMaxLength(20);
            entity.Property(e => e.TransferDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<InhouseTransferReceivedRow>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("InhouseTransferReceivedRow", "pos");

            entity.Property(e => e.ItemCode).HasMaxLength(20);
            entity.Property(e => e.ItemName).HasMaxLength(500);
            entity.Property(e => e.ReceivedQty).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<InhouseTransferRequestHeader>(entity =>
        {
            entity.HasKey(e => e.RequestId).HasName("PK_PurchaseRequestHeader");

            entity.ToTable("InhouseTransferRequestHeader", "pos");

            entity.Property(e => e.ActionByName).HasMaxLength(200);
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.CurrencyName).HasMaxLength(100);
            entity.Property(e => e.DeliveryAddress).HasMaxLength(200);
            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ExpectedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Grncode)
                .HasMaxLength(20)
                .HasColumnName("GRNCode");
            entity.Property(e => e.Grnid).HasColumnName("GRNId");
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.PartnerName).HasMaxLength(100);
            entity.Property(e => e.Purpose).HasMaxLength(200);
            entity.Property(e => e.Remarks).HasMaxLength(300);
            entity.Property(e => e.RequestCode).HasMaxLength(50);
            entity.Property(e => e.RequestDate).HasColumnType("date");
            entity.Property(e => e.RequestTypeId).HasDefaultValueSql("((1))");
            entity.Property(e => e.RequestTypeName)
                .HasMaxLength(100)
                .HasDefaultValueSql("('Inhouse Transfer')");
            entity.Property(e => e.Review)
                .HasMaxLength(400)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ServerDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TotalApproveQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalInQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalOutQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalRequestQty).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<InhouseTransferRequestRow>(entity =>
        {
            entity.HasKey(e => e.RowId).HasName("PK_PurchaseRequestRow");

            entity.ToTable("InhouseTransferRequestRow", "pos");

            entity.Property(e => e.ApproveQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Barcode)
                .HasMaxLength(20)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.ItemCode).HasMaxLength(100);
            entity.Property(e => e.ItemName).HasMaxLength(1000);
            entity.Property(e => e.RequestQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RestQty)
                .HasComputedColumnSql("([RequestQty]-[TransferQty])", false)
                .HasColumnType("decimal(19, 2)");
            entity.Property(e => e.TransferInQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransferQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UomName).HasMaxLength(100);
        });

        modelBuilder.Entity<ItemSellingPriceHeader>(entity =>
        {
            entity.HasKey(e => e.HeaderId);

            entity.ToTable("ItemSellingPriceHeader", "pos");

            entity.HasIndex(e => new { e.AccountId, e.BranchId, e.OfficeId, e.WarehouseId }, "NonClusteredIndex-20230415-124043");

            entity.Property(e => e.AmountOrPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApproveDatetime).HasColumnType("datetime");
            entity.Property(e => e.CancelDatetime).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsMarkUp)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(300);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionCode).HasMaxLength(30);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ItemSellingPriceHeaderTemp>(entity =>
        {
            entity.HasKey(e => e.HeaderId).HasName("ItemSellingPriceHeaderTemp2");

            entity.ToTable("ItemSellingPriceHeaderTemp", "pos");

            entity.Property(e => e.HeaderId).ValueGeneratedNever();
            entity.Property(e => e.AmountOrPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApproveDatetime).HasColumnType("datetime");
            entity.Property(e => e.CancelDatetime).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.Remarks).HasMaxLength(300);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionCode).HasMaxLength(30);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ItemSellingPriceRow>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("ItemSellingPriceRow", "pos");

            entity.HasIndex(e => e.ItemId, "NonClusteredIndex-20230415-124013");

            entity.Property(e => e.AltQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.NewPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ItemSellingPriceRowMarkupDown>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("ItemSellingPriceRowMarkupDown", "pos");

            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.NewPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ItemSellingPriceRowTemp>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("ItemSellingPriceRowTemp", "pos");

            entity.Property(e => e.RowId).ValueGeneratedNever();
            entity.Property(e => e.AltQty).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.NewPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.OldPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ItemVariant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ItemVariant", "pos");

            entity.Property(e => e.ItemVariantId).ValueGeneratedOnAdd();
            entity.Property(e => e.ItemVariantName).HasMaxLength(50);
        });

        modelBuilder.Entity<ItemVariantConfig>(entity =>
        {
            entity.ToTable("ItemVariantConfig", "pos");

            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.VariantName).HasMaxLength(30);
            entity.Property(e => e.VariantValue).HasMaxLength(50);
        });

        modelBuilder.Entity<MonthlyPhysicalStockUpdate>(entity =>
        {
            entity.HasKey(e => e.StockUpdateId);

            entity.ToTable("MonthlyPhysicalStockUpdate", "pos");

            entity.Property(e => e.AutoCode).HasMaxLength(50);
            entity.Property(e => e.ItemCode).HasMaxLength(50);
            entity.Property(e => e.ItemName).HasMaxLength(250);
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ServerDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Poscounter>(entity =>
        {
            entity.HasKey(e => e.CounterId);

            entity.ToTable("POSCounter", "pos");

            entity.Property(e => e.CounterClosingDate).HasColumnType("datetime");
            entity.Property(e => e.CounterCode).HasMaxLength(50);
            entity.Property(e => e.CounterName).HasMaxLength(100);
            entity.Property(e => e.CounterOpeningDate).HasColumnType("datetime");
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.ServerDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(200)
                .HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<PossalesDeliveryHeader>(entity =>
        {
            entity.HasKey(e => e.SalesOrderId).HasName("PK__SalesOrd__3214EC271C2B5E67");

            entity.ToTable("POSSalesDeliveryHeader", "pos");

            entity.HasIndex(e => new { e.CounterId, e.OrderDate }, "NonClusteredIndex-20230420-002003");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.ActionByName).HasMaxLength(100);
            entity.Property(e => e.ActionTime).HasColumnType("datetime");
            entity.Property(e => e.AdvanceBalanceAdjust).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountPerInstallment).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AnonymousAddress).HasMaxLength(500);
            entity.Property(e => e.BillNo).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CashPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChallanNo).HasMaxLength(250);
            entity.Property(e => e.ComissionPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CounterId).HasDefaultValueSql("((0))");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.CustomerNetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerPo)
                .HasMaxLength(100)
                .HasColumnName("CustomerPO");
            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.DiscoundItemTotalPrice)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FreeTypeName).HasMaxLength(100);
            entity.Property(e => e.HeaderDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.HeaderDiscountPercentage).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InstallmentStartDate).HasColumnType("date");
            entity.Property(e => e.InstallmentType).HasMaxLength(20);
            entity.Property(e => e.InterestRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsConfirmed)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsInclusive)
                .HasDefaultValueSql("((0))")
                .HasColumnName("isInclusive");
            entity.Property(e => e.IsOnline).HasDefaultValueSql("((0))");
            entity.Property(e => e.IsProcess).HasDefaultValueSql("((0))");
            entity.Property(e => e.Isexchange).HasColumnName("ISExchange");
            entity.Property(e => e.Isreturn).HasColumnName("ISReturn");
            entity.Property(e => e.ItemTotalAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NetAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NetAmountWithInterest).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NetDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OfferItemTotal)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderDate).HasColumnType("date");
            entity.Property(e => e.OthersCost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PaymentTypeName).HasMaxLength(100);
            entity.Property(e => e.PendingAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Phone).HasMaxLength(100);
            entity.Property(e => e.PointRedeemCode).HasMaxLength(100);
            entity.Property(e => e.Points).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProjectName).HasMaxLength(300);
            entity.Property(e => e.ReceiveAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.RedeemPoint)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RedeemPointValue)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ReturnAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SalesForceName).HasMaxLength(100);
            entity.Property(e => e.SalesOrReturn).HasMaxLength(50);
            entity.Property(e => e.SalesOrderCode).HasMaxLength(50);
            entity.Property(e => e.SalesTypeName).HasMaxLength(100);
            entity.Property(e => e.ShippingAddressId).HasDefaultValueSql("((0))");
            entity.Property(e => e.ShippingAddressName).HasMaxLength(200);
            entity.Property(e => e.ShippingContactPerson)
                .HasMaxLength(200)
                .HasDefaultValueSql("(N'N/A')");
            entity.Property(e => e.TotalLineDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalQuantity).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalSd)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalVat)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PossalesDeliveryHeaderTemp>(entity =>
        {
            entity.HasKey(e => e.SalesOrderId).HasName("PK__SalesOrdTemp__3214EC271C2B5E67");

            entity.ToTable("POSSalesDeliveryHeaderTemp", "pos");

            entity.Property(e => e.AccountName).HasMaxLength(100);
            entity.Property(e => e.ActionByName).HasMaxLength(100);
            entity.Property(e => e.ActionTime).HasColumnType("datetime");
            entity.Property(e => e.AdvanceBalanceAdjust).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AmountPerInstallment).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.AnonymousAddress).HasMaxLength(500);
            entity.Property(e => e.BillNo).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CashPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChallanNo).HasMaxLength(250);
            entity.Property(e => e.ComissionPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.CustomerNetAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustomerPo)
                .HasMaxLength(100)
                .HasColumnName("CustomerPO");
            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.DiscoundItemTotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FreeTypeName).HasMaxLength(100);
            entity.Property(e => e.HeaderDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.HeaderDiscountPercentage).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InstallmentStartDate).HasColumnType("date");
            entity.Property(e => e.InstallmentType).HasMaxLength(20);
            entity.Property(e => e.InterestRate).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsInclusive).HasColumnName("isInclusive");
            entity.Property(e => e.Isexchange).HasColumnName("ISExchange");
            entity.Property(e => e.ItemTotalAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NetAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NetAmountWithInterest).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NetDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OfferItemTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderDate).HasColumnType("date");
            entity.Property(e => e.OthersCost).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.PaymentTypeName).HasMaxLength(100);
            entity.Property(e => e.PendingAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Phone).HasMaxLength(100);
            entity.Property(e => e.Points).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProjectName).HasMaxLength(300);
            entity.Property(e => e.ReceiveAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ReturnAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SalesForceName).HasMaxLength(100);
            entity.Property(e => e.SalesOrReturn).HasMaxLength(50);
            entity.Property(e => e.SalesOrderCode).HasMaxLength(50);
            entity.Property(e => e.SalesTypeName).HasMaxLength(100);
            entity.Property(e => e.ShippingAddressName).HasMaxLength(200);
            entity.Property(e => e.ShippingContactPerson).HasMaxLength(200);
            entity.Property(e => e.TotalLineDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalQuantity).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.TotalSd).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalVat).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PossalesDeliveryLine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SalesOrd__3214EC272C21004E");

            entity.ToTable("POSSalesDeliveryLine", "pos");

            entity.Property(e => e.AnonymousAddress).HasMaxLength(500);
            entity.Property(e => e.ChangeQuantity)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountType)
                .HasMaxLength(200)
                .HasDefaultValueSql("('')");
            entity.Property(e => e.FreeTypeId).HasDefaultValueSql("((0))");
            entity.Property(e => e.FreeTypeName).HasMaxLength(100);
            entity.Property(e => e.HeaderCostProportion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.HeaderDiscountProportion)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ItemBasePriceInclusive).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ItemDescription).HasMaxLength(2000);
            entity.Property(e => e.ItemName).HasMaxLength(1000);
            entity.Property(e => e.LineDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NetAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OfferItemName)
                .HasMaxLength(250)
                .HasDefaultValueSql("(N'N/A')");
            entity.Property(e => e.OfferItemQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OtherDiscount).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SdAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SdPercentage)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UomName).HasMaxLength(50);
            entity.Property(e => e.VatAmount)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VatPercentage)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 2)");
            entity.Property(e => e.WarehouseId).HasDefaultValueSql("((0))");
            entity.Property(e => e.WarrantyExpiredDate).HasColumnType("date");
        });

        modelBuilder.Entity<PossalesDeliveryLineTemp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SalesOrdTemp__3214EC272C21004E");

            entity.ToTable("POSSalesDeliveryLineTemp", "pos");

            entity.Property(e => e.AnonymousAddress).HasMaxLength(500);
            entity.Property(e => e.ChangeQuantity).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.CostPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountType).HasMaxLength(200);
            entity.Property(e => e.FreeTypeName).HasMaxLength(100);
            entity.Property(e => e.HeaderCostProportion).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.HeaderDiscountProportion).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.ItemBasePriceInclusive).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ItemDescription).HasMaxLength(2000);
            entity.Property(e => e.ItemName).HasMaxLength(1000);
            entity.Property(e => e.LineDiscount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.NetAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.OfferItemName).HasMaxLength(250);
            entity.Property(e => e.OfferItemQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.SdAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SdPercentage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAmount).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.UomName).HasMaxLength(50);
            entity.Property(e => e.VatAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VatPercentage).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.WarrantyExpiredDate).HasColumnType("date");
        });

        modelBuilder.Entity<PossalesPayment>(entity =>
        {
            entity.ToTable("POSSalesPayment", "pos");

            entity.Property(e => e.PossalesPaymentId).HasColumnName("POSSalesPaymentId");
            entity.Property(e => e.CollectionAmount).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.ReferanceNo).HasMaxLength(13);
            entity.Property(e => e.ServerDatetime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PosspecialDiscount>(entity =>
        {
            entity.HasKey(e => e.HeaderId);

            entity.ToTable("POSSpecialDiscount", "pos");

            entity.Property(e => e.CustomerGroupIds).HasColumnName("CustomerGroupIDs");
            entity.Property(e => e.DiscountType).HasComment("DiscountType 1 = Percentage,2=Amount");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IsOpenDiscount).HasDefaultValueSql("((0))");
            entity.Property(e => e.LastActionDatetime).HasColumnType("datetime");
            entity.Property(e => e.MaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MinAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OfferName).HasMaxLength(100);
            entity.Property(e => e.Remarks).HasMaxLength(300);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Value).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<PosspecialDiscountCustomerInfo>(entity =>
        {
            entity.HasKey(e => e.IntRowId).HasName("PK__POSSpeci__C2D8306BD8433211");

            entity.ToTable("POSSpecialDiscountCustomerInfo", "pos");

            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.StrCustomerName).HasMaxLength(500);
        });

        modelBuilder.Entity<TblAuditSetupHead>(entity =>
        {
            entity.HasKey(e => e.AuditSetupId).HasName("PK__tblAudit__81F4B78925C4F8AE");

            entity.ToTable("tblAuditSetupHead", "pos");

            entity.Property(e => e.DteActionDateTime)
                .HasColumnType("datetime")
                .HasColumnName("dteActionDateTime");
            entity.Property(e => e.DteCreatedDate)
                .HasColumnType("datetime")
                .HasColumnName("dteCreatedDate");
            entity.Property(e => e.DteEndDate)
                .HasColumnType("datetime")
                .HasColumnName("dteEndDate");
            entity.Property(e => e.DteServerDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dteServerDateTime");
            entity.Property(e => e.DteStartDate)
                .HasColumnType("datetime")
                .HasColumnName("dteStartDate");
            entity.Property(e => e.IntAccountId).HasColumnName("intAccountId");
            entity.Property(e => e.IntActionBy).HasColumnName("intActionBy");
            entity.Property(e => e.IntApproveBy).HasColumnName("intApproveBy");
            entity.Property(e => e.IntBranchId).HasColumnName("intBranchId");
            entity.Property(e => e.IntOfficeId).HasColumnName("intOfficeId");
            entity.Property(e => e.IntRejectBy).HasColumnName("intRejectBy");
            entity.Property(e => e.IntWarehouseId).HasColumnName("intWarehouseId");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.IsApprove).HasColumnName("isApprove");
            entity.Property(e => e.IsComplete).HasColumnName("isComplete");
            entity.Property(e => e.IsReject).HasColumnName("isReject");
            entity.Property(e => e.StrAuditSetupCode)
                .HasMaxLength(50)
                .HasColumnName("strAuditSetupCode");
            entity.Property(e => e.StrRemarks)
                .HasMaxLength(150)
                .HasColumnName("strRemarks");
        });

        modelBuilder.Entity<TblAuditSetupRow>(entity =>
        {
            entity.HasKey(e => e.RowId).HasName("PK__tblAudit__FFEE743193DFAC3D");

            entity.ToTable("tblAuditSetupRow", "pos");

            entity.Property(e => e.DteActionDateTime)
                .HasColumnType("datetime")
                .HasColumnName("dteActionDateTime");
            entity.Property(e => e.DteServerDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("dteServerDateTime");
            entity.Property(e => e.IntCategoryId).HasColumnName("intCategoryId");
            entity.Property(e => e.IntSubCategoryId).HasColumnName("intSubCategoryId");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.StrCategoryCode)
                .HasMaxLength(50)
                .HasColumnName("strCategoryCode");
            entity.Property(e => e.StrCategoryName)
                .HasMaxLength(100)
                .HasColumnName("strCategoryName");
            entity.Property(e => e.StrSubCategoryName)
                .HasMaxLength(50)
                .HasColumnName("strSubCategoryName");
        });

        modelBuilder.Entity<TblDataLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblDataLog", "pos");

            entity.Property(e => e.IsSync).HasColumnName("isSync");
            entity.Property(e => e.LastActionDateTime).HasColumnType("datetime");
            entity.Property(e => e.LogType).HasMaxLength(50);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StrEntityData).HasColumnName("strEntityData");
            entity.Property(e => e.StrLogMessage)
                .HasMaxLength(500)
                .HasColumnName("strLogMessage");
        });

        modelBuilder.Entity<TblPointRedemptionHeader>(entity =>
        {
            entity.HasKey(e => e.PointRedemptionId).HasName("PK__tblPoint__C358A61306FBB8FC");

            entity.ToTable("tblPointRedemptionHeader", "pos");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FromDate).HasColumnType("datetime");
            entity.Property(e => e.IntRejectBy).HasColumnName("intRejectBy");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.IsReject).HasColumnName("isReject");
            entity.Property(e => e.LastActonDateTime).HasColumnType("datetime");
            entity.Property(e => e.PointRedemptionCode).HasMaxLength(100);
            entity.Property(e => e.PointRedemptionCodePrefix).HasMaxLength(50);
            entity.Property(e => e.PointRedemptionName).HasMaxLength(200);
            entity.Property(e => e.PointRedemptionTypeName).HasMaxLength(100);
            entity.Property(e => e.RedeemPercentage).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Remarks).HasMaxLength(500);
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TblPointRedemptionRow>(entity =>
        {
            entity.HasKey(e => e.PointRedemptionRowId).HasName("PK__tblPoint__EB6DBA64B0B4A392");

            entity.ToTable("tblPointRedemptionRow", "pos");

            entity.Property(e => e.ActivationDate).HasColumnType("datetime");
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.CustomerMobile).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
            entity.Property(e => e.GainedPoint).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastActonDateTime).HasColumnType("datetime");
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.RedeemCode).HasMaxLength(100);
            entity.Property(e => e.RedeemPoint).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.RemainingPoint).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ServerDateTime)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
