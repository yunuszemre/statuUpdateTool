using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace statuUpdateTool.Tms_Models
{
    public partial class cl_tmsContext : DbContext
    {
        public cl_tmsContext()
        {
        }

        public cl_tmsContext(DbContextOptions<cl_tmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AccountCarrierBlacklist> AccountCarrierBlacklists { get; set; } = null!;
        public virtual DbSet<AccountCarrierDistanceDesiCost> AccountCarrierDistanceDesiCosts { get; set; } = null!;
        public virtual DbSet<AccountCarrierPlannedShipmentConfiguration> AccountCarrierPlannedShipmentConfigurations { get; set; } = null!;
        public virtual DbSet<AccountCriteriaPriorityMapping> AccountCriteriaPriorityMappings { get; set; } = null!;
        public virtual DbSet<AccountDecisionRule> AccountDecisionRules { get; set; } = null!;
        public virtual DbSet<AccountLocationWorkingSchedule> AccountLocationWorkingSchedules { get; set; } = null!;
        public virtual DbSet<AccountSalesChannelConfiguration> AccountSalesChannelConfigurations { get; set; } = null!;
        public virtual DbSet<AccountServiceTypeRule> AccountServiceTypeRules { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<AddressMapping> AddressMappings { get; set; } = null!;
        public virtual DbSet<AddressMappingDetail> AddressMappingDetails { get; set; } = null!;
        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<CarDriver> CarDrivers { get; set; } = null!;
        public virtual DbSet<Carrier> Carriers { get; set; } = null!;
        public virtual DbSet<CarrierDeliveryPerformance> CarrierDeliveryPerformances { get; set; } = null!;
        public virtual DbSet<CarrierDeliveryType> CarrierDeliveryTypes { get; set; } = null!;
        public virtual DbSet<CarrierDistanceBetweenCityGroup> CarrierDistanceBetweenCityGroups { get; set; } = null!;
        public virtual DbSet<CarrierDistanceLookup> CarrierDistanceLookups { get; set; } = null!;
        public virtual DbSet<CarrierRouteMapping> CarrierRouteMappings { get; set; } = null!;
        public virtual DbSet<CarrierRouteMapping27122022Ydk> CarrierRouteMapping27122022Ydks { get; set; } = null!;
        public virtual DbSet<CarrierRouteMappingMobileBranch> CarrierRouteMappingMobileBranches { get; set; } = null!;
        public virtual DbSet<CarrierShipmentStatus> CarrierShipmentStatuses { get; set; } = null!;
        public virtual DbSet<CarrierShipmentStatusNotMatch> CarrierShipmentStatusNotMatches { get; set; } = null!;
        public virtual DbSet<CarrierValueMapping> CarrierValueMappings { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<ClientValueMapping> ClientValueMappings { get; set; } = null!;
        public virtual DbSet<Consignment> Consignments { get; set; } = null!;
        public virtual DbSet<ConsignmentConfiguration> ConsignmentConfigurations { get; set; } = null!;
        public virtual DbSet<ConsignmentDetail> ConsignmentDetails { get; set; } = null!;
        public virtual DbSet<Counter> Counters { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerSegment> CustomerSegments { get; set; } = null!;
        public virtual DbSet<District> Districts { get; set; } = null!;
        public virtual DbSet<DocumentTemplate> DocumentTemplates { get; set; } = null!;
        public virtual DbSet<Hash> Hashes { get; set; } = null!;
        public virtual DbSet<IntegrationHistory> IntegrationHistories { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<JobParameter> JobParameters { get; set; } = null!;
        public virtual DbSet<JobQueue> JobQueues { get; set; } = null!;
        public virtual DbSet<JobTracking> JobTrackings { get; set; } = null!;
        public virtual DbSet<List> Lists { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<LocationCarrierConfiguration> LocationCarrierConfigurations { get; set; } = null!;
        public virtual DbSet<Menu> Menus { get; set; } = null!;
        public virtual DbSet<OperationClaim> OperationClaims { get; set; } = null!;
        public virtual DbSet<OperationRole> OperationRoles { get; set; } = null!;
        public virtual DbSet<OperationRoleOperationClaim> OperationRoleOperationClaims { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<PlannedShipmentWorkingSchedule> PlannedShipmentWorkingSchedules { get; set; } = null!;
        public virtual DbSet<ProcessGroup> ProcessGroups { get; set; } = null!;
        public virtual DbSet<ProductConfiguration> ProductConfigurations { get; set; } = null!;
        public virtual DbSet<Ptt> Ptts { get; set; } = null!;
        public virtual DbSet<ReportHistory> ReportHistories { get; set; } = null!;
        public virtual DbSet<ReportScript> ReportScripts { get; set; } = null!;
        public virtual DbSet<ReportScriptParameter> ReportScriptParameters { get; set; } = null!;
        public virtual DbSet<Return> Returns { get; set; } = null!;
        public virtual DbSet<ReturnItem> ReturnItems { get; set; } = null!;
        public virtual DbSet<RmaReason> RmaReasons { get; set; } = null!;
        public virtual DbSet<Route> Routes { get; set; } = null!;
        public virtual DbSet<RouteLocation> RouteLocations { get; set; } = null!;
        public virtual DbSet<SalesChannel> SalesChannels { get; set; } = null!;
        public virtual DbSet<Schema> Schemas { get; set; } = null!;
        public virtual DbSet<Segment> Segments { get; set; } = null!;
        public virtual DbSet<Server> Servers { get; set; } = null!;
        public virtual DbSet<Set> Sets { get; set; } = null!;
        public virtual DbSet<Shipment> Shipments { get; set; } = null!;
        public virtual DbSet<ShipmentCarrierHistory> ShipmentCarrierHistories { get; set; } = null!;
        public virtual DbSet<ShipmentDeliveryReceipt> ShipmentDeliveryReceipts { get; set; } = null!;
        public virtual DbSet<ShipmentDeliveryReceiptLine> ShipmentDeliveryReceiptLines { get; set; } = null!;
        public virtual DbSet<ShipmentDetail> ShipmentDetails { get; set; } = null!;
        public virtual DbSet<ShipmentDetailLine> ShipmentDetailLines { get; set; } = null!;
        public virtual DbSet<ShipmentDocument> ShipmentDocuments { get; set; } = null!;
        public virtual DbSet<ShipmentHistory> ShipmentHistories { get; set; } = null!;
        public virtual DbSet<ShipmentPattern> ShipmentPatterns { get; set; } = null!;
        public virtual DbSet<ShipmentStatusMapping> ShipmentStatusMappings { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<StatusLookup> StatusLookups { get; set; } = null!;
        public virtual DbSet<Town> Towns { get; set; } = null!;
        public virtual DbSet<TypeLookup> TypeLookups { get; set; } = null!;
        public virtual DbSet<UserIdentity> UserIdentities { get; set; } = null!;
        public virtual DbSet<UserIdentityAccount> UserIdentityAccounts { get; set; } = null!;
        public virtual DbSet<UserIdentityClient> UserIdentityClients { get; set; } = null!;
        public virtual DbSet<UserIdentityLocation> UserIdentityLocations { get; set; } = null!;
        public virtual DbSet<UserIdentityOperationClaim> UserIdentityOperationClaims { get; set; } = null!;
        public virtual DbSet<UserIdentityOperationRole> UserIdentityOperationRoles { get; set; } = null!;
        public virtual DbSet<ValueMapping> ValueMappings { get; set; } = null!;
        public virtual DbSet<WebHookSubscription> WebHookSubscriptions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=10.10.10.32,1439;Database=cl_tms;uid=sa;pwd=123Dasd17465Ccas");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ChangeUserIdentity)
                    .WithMany(p => p.AccountChangeUserIdentities)
                    .HasForeignKey(d => d.ChangeUserIdentityId)
                    .HasConstraintName("FK_Account_UserIdentity1");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_Client");

                entity.HasOne(d => d.CreateUserIdentity)
                    .WithMany(p => p.AccountCreateUserIdentities)
                    .HasForeignKey(d => d.CreateUserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Account_UserIdentity");
            });

            modelBuilder.Entity<AccountCarrierBlacklist>(entity =>
            {
                entity.ToTable("AccountCarrierBlacklist");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountCarrierBlacklists)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCarrierBlacklist_Account");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.AccountCarrierBlacklists)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCarrierBlacklist_Carrier");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AccountCarrierBlacklists)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_AccountCarrierBlacklist_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AccountCarrierBlacklists)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_AccountCarrierBlacklist_Country");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.AccountCarrierBlacklists)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_AccountCarrierBlacklist_District");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.AccountCarrierBlacklists)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_AccountCarrierBlacklist_Location");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.AccountCarrierBlacklists)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_AccountCarrierBlacklist_Town");
            });

            modelBuilder.Entity<AccountCarrierDistanceDesiCost>(entity =>
            {
                entity.ToTable("AccountCarrierDistanceDesiCost");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IfSelectedPlusDesi).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaxDesi).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxHeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxLength).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxWidth).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinDesi).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinHeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinLength).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinWidth).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountCarrierDistanceDesiCosts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCarrierDistanceDesiCost_Account");

                entity.HasOne(d => d.CarrierDistanceLookup)
                    .WithMany(p => p.AccountCarrierDistanceDesiCosts)
                    .HasForeignKey(d => d.CarrierDistanceLookupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCarrierDistanceDesiCost_CarrierDistanceLookup");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.AccountCarrierDistanceDesiCosts)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCarrierDistanceDesiCost_Carrier");
            });

            modelBuilder.Entity<AccountCarrierPlannedShipmentConfiguration>(entity =>
            {
                entity.ToTable("AccountCarrierPlannedShipmentConfiguration");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.DeliverySlotType)
                    .WithMany(p => p.AccountCarrierPlannedShipmentConfigurationDeliverySlotTypes)
                    .HasForeignKey(d => d.DeliverySlotTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCarrierPlannedShipmentConfiguration_TypeLookup1");

                entity.HasOne(d => d.DeliveryType)
                    .WithMany(p => p.AccountCarrierPlannedShipmentConfigurationDeliveryTypes)
                    .HasForeignKey(d => d.DeliveryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCarrierPlannedShipmentConfiguration_TypeLookup");

                entity.HasOne(d => d.LocationCarrierConfiguration)
                    .WithMany(p => p.AccountCarrierPlannedShipmentConfigurations)
                    .HasForeignKey(d => d.LocationCarrierConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCarrierPlannedShipmentConfiguration_LocationCarrierConfiguration");
            });

            modelBuilder.Entity<AccountCriteriaPriorityMapping>(entity =>
            {
                entity.ToTable("AccountCriteriaPriorityMapping");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountCriteriaPriorityMappings)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCriteriaPriorityMapping_Account");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AccountCriteriaPriorityMappings)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCriteriaPriorityMapping_Client");

                entity.HasOne(d => d.CriteriaType)
                    .WithMany(p => p.AccountCriteriaPriorityMappings)
                    .HasForeignKey(d => d.CriteriaTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountCriteriaPriorityMapping_TypeLookup");
            });

            modelBuilder.Entity<AccountDecisionRule>(entity =>
            {
                entity.ToTable("AccountDecisionRule");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.ConsignmentSegment).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(50);

                entity.Property(e => e.CustomerSegment).HasMaxLength(50);

                entity.Property(e => e.MaxTotalPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxVolumetricWeight).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.MinTotalPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinVolumetricWeight).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountDecisionRules)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountDecisionRule_Account");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.AccountDecisionRules)
                    .HasForeignKey(d => d.CarrierId)
                    .HasConstraintName("FK_AccountDecisionRule_Carrier");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AccountDecisionRules)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_AccountDecisionRule_City");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AccountDecisionRules)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountDecisionRule_Client");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AccountDecisionRules)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountDecisionRule_Country");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.AccountDecisionRules)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_AccountDecisionRule_Customer");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.AccountDecisionRules)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_AccountDecisionRule_District");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.AccountDecisionRules)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountDecisionRule_Location");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.AccountDecisionRules)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_AccountDecisionRule_TypeLookup");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.AccountDecisionRules)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_AccountDecisionRule_Town");
            });

            modelBuilder.Entity<AccountLocationWorkingSchedule>(entity =>
            {
                entity.ToTable("AccountLocationWorkingSchedule");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WorkingScheduleDescription).HasMaxLength(100);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountLocationWorkingSchedules)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountLocationWorkingSchedule_Account");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.AccountLocationWorkingSchedules)
                    .HasForeignKey(d => d.CarrierId)
                    .HasConstraintName("FK_AccountLocationWorkingSchedule_Carrier");

                entity.HasOne(d => d.ChangeUserIdentity)
                    .WithMany(p => p.AccountLocationWorkingScheduleChangeUserIdentities)
                    .HasForeignKey(d => d.ChangeUserIdentityId)
                    .HasConstraintName("FK_AccountLocationWorkingSchedule_UserIdentity1");

                entity.HasOne(d => d.CreateUserIdentity)
                    .WithMany(p => p.AccountLocationWorkingScheduleCreateUserIdentities)
                    .HasForeignKey(d => d.CreateUserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountLocationWorkingSchedule_UserIdentity");

                entity.HasOne(d => d.WeekDayType)
                    .WithMany(p => p.AccountLocationWorkingSchedules)
                    .HasForeignKey(d => d.WeekDayTypeId)
                    .HasConstraintName("FK_AccountLocationWorkingSchedule_TypeLookup");
            });

            modelBuilder.Entity<AccountSalesChannelConfiguration>(entity =>
            {
                entity.ToTable("AccountSalesChannelConfiguration");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MerchantId).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceUrl).HasMaxLength(255);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountSalesChannelConfigurations)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountSalesChannelConfiguration_Account");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AccountSalesChannelConfigurations)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountSalesChannelConfiguration_Client");

                entity.HasOne(d => d.SalesChannel)
                    .WithMany(p => p.AccountSalesChannelConfigurations)
                    .HasForeignKey(d => d.SalesChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountSalesChannelConfiguration_SalesChannel");
            });

            modelBuilder.Entity<AccountServiceTypeRule>(entity =>
            {
                entity.ToTable("AccountServiceTypeRule");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountServiceTypeRules)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountServiceTypeRule_Account");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.AccountServiceTypeRules)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountServiceTypeRule_Carrier");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AccountServiceTypeRules)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_AccountServiceTypeRule_City");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.AccountServiceTypeRules)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountServiceTypeRule_Client");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AccountServiceTypeRules)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountServiceTypeRule_Country");

                entity.HasOne(d => d.DeliverySlotType)
                    .WithMany(p => p.AccountServiceTypeRuleDeliverySlotTypes)
                    .HasForeignKey(d => d.DeliverySlotTypeId)
                    .HasConstraintName("FK_AccountServiceTypeRule_DeliverySlotTypeLookup");

                entity.HasOne(d => d.DeliveryType)
                    .WithMany(p => p.AccountServiceTypeRuleDeliveryTypes)
                    .HasForeignKey(d => d.DeliveryTypeId)
                    .HasConstraintName("FK_AccountServiceTypeRule_DeliveryTypeLookup");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.AccountServiceTypeRules)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_AccountServiceTypeRule_District");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.AccountServiceTypeRules)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountServiceTypeRule_Location");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.AccountServiceTypeRulePaymentTypes)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_AccountServiceTypeRule_TypeLookup");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.AccountServiceTypeRules)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_AccountServiceTypeRule_Town");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.AddressCode).HasMaxLength(50);

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ZipCode).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Address_Account");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_City");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Client");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Country");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Address_Customer");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Address_Location");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_Address_Town");

                entity.HasOne(d => d.TypeLookup)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.TypeLookupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_TypeLookup");
            });

            modelBuilder.Entity<AddressMapping>(entity =>
            {
                entity.ToTable("AddressMapping");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<AddressMappingDetail>(entity =>
            {
                entity.ToTable("AddressMappingDetail");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.ToTable("Car");

                entity.Property(e => e.CarPlate).HasMaxLength(50);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountId");

                entity.HasOne(d => d.CarType)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.CarTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarTypeId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientId");
            });

            modelBuilder.Entity<CarDriver>(entity =>
            {
                entity.ToTable("CarDriver");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CarDrivers)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CarDriver_FK3");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.CarDrivers)
                    .HasForeignKey(d => d.CarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CarDriver_FK");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CarDrivers)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CarDriver_FK4");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.CarDrivers)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CarDriver_FK2");
            });

            modelBuilder.Entity<Carrier>(entity =>
            {
                entity.ToTable("Carrier");

                entity.Property(e => e.AddressLine).HasMaxLength(200);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CodcashSupport).HasColumnName("CODCashSupport");

                entity.Property(e => e.CodcreditCardSupport).HasColumnName("CODCreditCardSupport");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MarketPlaceCustomerToCustomerServiceUrl).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReturnServiceUrl).HasMaxLength(500);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ServiceUrl).HasMaxLength(500);

                entity.Property(e => e.StatusServiceUrl).HasMaxLength(500);

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.TaxNumber).HasMaxLength(50);

                entity.Property(e => e.ZipCode).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Carriers)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Carrier_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Carriers)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Carrier_Country");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Carriers)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Carrier_Neighborhood");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Carriers)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_Carrier_Town");
            });

            modelBuilder.Entity<CarrierDeliveryPerformance>(entity =>
            {
                entity.ToTable("CarrierDeliveryPerformance");

                entity.HasIndex(e => e.RecipientDistrictId, "IX_CarrierDeliveryPerformance_RecipientDistrictId");

                entity.Property(e => e.AverageDeliveryDay).HasColumnType("decimal(38, 0)");

                entity.Property(e => e.AverageDeliveryRate).HasColumnType("decimal(38, 0)");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecipientCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientDistrict)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientTown)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SenderCity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SenderDistrict)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SenderTown)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarrierDeliveryType>(entity =>
            {
                entity.ToTable("CarrierDeliveryType");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.CarrierDeliveryTypes)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierDeliveryType_Carrier");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CarrierDeliveryTypes)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_CarrierDeliveryType_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CarrierDeliveryTypes)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierDeliveryType_Country");

                entity.HasOne(d => d.DeliverySlotType)
                    .WithMany(p => p.CarrierDeliveryTypes)
                    .HasForeignKey(d => d.DeliverySlotTypeId)
                    .HasConstraintName("FK_CarrierDeliveryType_TypeLookup1");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.CarrierDeliveryTypes)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_CarrierDeliveryType_District");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.CarrierDeliveryTypes)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_CarrierDeliveryType_Town");
            });

            modelBuilder.Entity<CarrierDistanceBetweenCityGroup>(entity =>
            {
                entity.ToTable("CarrierDistanceBetweenCityGroup");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CarrierDistanceLookup)
                    .WithMany(p => p.CarrierDistanceBetweenCityGroups)
                    .HasForeignKey(d => d.CarrierDistanceLookupId)
                    .HasConstraintName("FK_CarrierDistanceBetweenCityGroup_CarrierDistanceLookup");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.CarrierDistanceBetweenCityGroups)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierDistanceBetweenCityGroup_Carrier");

                entity.HasOne(d => d.CityGroupType)
                    .WithMany(p => p.CarrierDistanceBetweenCityGroupCityGroupTypes)
                    .HasForeignKey(d => d.CityGroupTypeId)
                    .HasConstraintName("FK_CarrierDistanceBetweenCityGroup_TypeLookup1");

                entity.HasOne(d => d.DistanceType)
                    .WithMany(p => p.CarrierDistanceBetweenCityGroupDistanceTypes)
                    .HasForeignKey(d => d.DistanceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierDistanceBetweenCityGroup_TypeLookup");

                entity.HasOne(d => d.FromCity)
                    .WithMany(p => p.CarrierDistanceBetweenCityGroupFromCities)
                    .HasForeignKey(d => d.FromCityId)
                    .HasConstraintName("FK_CarrierDistanceBetweenCityGroup_City");

                entity.HasOne(d => d.ToCity)
                    .WithMany(p => p.CarrierDistanceBetweenCityGroupToCities)
                    .HasForeignKey(d => d.ToCityId)
                    .HasConstraintName("FK_CarrierDistanceBetweenCityGroup_City1");
            });

            modelBuilder.Entity<CarrierDistanceLookup>(entity =>
            {
                entity.ToTable("CarrierDistanceLookup");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.CarrierDistanceLookups)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierDistanceLookup_Carrier");
            });

            modelBuilder.Entity<CarrierRouteMapping>(entity =>
            {
                entity.ToTable("CarrierRouteMapping");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.CarrierRouteMappings)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierRouteMapping_Carrier");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CarrierRouteMappings)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_CarrierRouteMapping_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CarrierRouteMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CarrierRouteMapping_Country");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.CarrierRouteMappings)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_CarrierRouteMapping_District");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.CarrierRouteMappings)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_CarrierRouteMapping_Town");
            });

            modelBuilder.Entity<CarrierRouteMapping27122022Ydk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CarrierRouteMapping_27122022_Ydk");

                entity.Property(e => e.CarrierRouteMappingId).ValueGeneratedOnAdd();

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CarrierRouteMappingMobileBranch>(entity =>
            {
                entity.ToTable("CarrierRouteMappingMobileBranch");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.CarrierRouteMapping)
                    .WithMany(p => p.CarrierRouteMappingMobileBranches)
                    .HasForeignKey(d => d.CarrierRouteMappingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierRouteMappingMobileBranch_CarrierRouteMapping");

                entity.HasOne(d => d.DeliverySlotType)
                    .WithMany(p => p.CarrierRouteMappingMobileBranches)
                    .HasForeignKey(d => d.DeliverySlotTypeId)
                    .HasConstraintName("FK_CarrierRouteMappingMobileBranch_TypeLookup");
            });

            modelBuilder.Entity<CarrierShipmentStatus>(entity =>
            {
                entity.ToTable("CarrierShipmentStatus");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.StatusCode).HasMaxLength(50);

                entity.Property(e => e.StatusDescription).HasMaxLength(500);

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.CarrierShipmentStatuses)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierDeliveryStatus_Carrier");
            });

            modelBuilder.Entity<CarrierShipmentStatusNotMatch>(entity =>
            {
                entity.ToTable("CarrierShipmentStatusNotMatch");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.Status).HasMaxLength(500);

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.CarrierShipmentStatusNotMatches)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierShipmentStatusNotMatch_Carrier");
            });

            modelBuilder.Entity<CarrierValueMapping>(entity =>
            {
                entity.ToTable("CarrierValueMapping");

                entity.Property(e => e.CarrierCityCode).HasMaxLength(50);

                entity.Property(e => e.CarrierCountryCode).HasMaxLength(50);

                entity.Property(e => e.CarrierDistrictCode).HasMaxLength(50);

                entity.Property(e => e.CarrierTownCode).HasMaxLength(50);

                entity.Property(e => e.CarrierZipCode).HasMaxLength(50);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ZipCode).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.CarrierValueMappings)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_CarrierValueMapping_Account");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CarrierValueMappings)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_CarrierValueMapping_City");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CarrierValueMappings)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CarrierValueMapping_Client");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CarrierValueMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_CarrierValueMapping_Country");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.CarrierValueMappings)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_CarrierValueMapping_District");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.CarrierValueMappings)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_CarrierValueMapping_Town");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_Country");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ClientValueMapping>(entity =>
            {
                entity.ToTable("ClientValueMapping");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.ClientCityCode).HasMaxLength(50);

                entity.Property(e => e.ClientCountryCode).HasMaxLength(50);

                entity.Property(e => e.ClientDistrictCode).HasMaxLength(50);

                entity.Property(e => e.ClientTownCode).HasMaxLength(50);

                entity.Property(e => e.ClientZipCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ZipCode).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ClientValueMappings)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_ClientValueMapping_City");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientValueMappings)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientValueMapping_Client");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ClientValueMappings)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_ClientValueMapping_Country");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.ClientValueMappings)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_ClientValueMapping_District");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.ClientValueMappings)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_ClientValueMapping_Town");
            });

            modelBuilder.Entity<Consignment>(entity =>
            {
                entity.ToTable("Consignment");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.ConsignmentNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CurrentPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EstimatedPackagingCompletionDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedPackagingCompletionDueDate).HasColumnType("datetime");

                entity.Property(e => e.ManuallyCreateNote).HasMaxLength(300);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SalesChannelTrackingNumber).HasMaxLength(50);

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.VolumetricWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipment_Account");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.CarrierId)
                    .HasConstraintName("FK_Shipment_Carrier");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipment_Client");

                entity.HasOne(d => d.ConsignmentStatus)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.ConsignmentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipment_StatusLookup");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipment_Location");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Shipment_Order");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_Shipment_TypeLookup");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_Route");

                entity.HasOne(d => d.SalesChannel)
                    .WithMany(p => p.Consignments)
                    .HasForeignKey(d => d.SalesChannelId)
                    .HasConstraintName("FK_Shipment_SalesChannel");
            });

            modelBuilder.Entity<ConsignmentConfiguration>(entity =>
            {
                entity.ToTable("ConsignmentConfiguration");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OmsApiPassword)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OmsApiUsername)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PerformanceRatio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceRatio).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReturnCodePrefix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ConsignmentConfigurations)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CargoConfiguration_Account");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ConsignmentConfigurations)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CargoConfiguration_Client");

                entity.HasOne(d => d.DefaultCarrier)
                    .WithMany(p => p.ConsignmentConfigurations)
                    .HasForeignKey(d => d.DefaultCarrierId)
                    .HasConstraintName("FK_ShipmentConfiguration_Carrier");
            });

            modelBuilder.Entity<ConsignmentDetail>(entity =>
            {
                entity.ToTable("ConsignmentDetail");

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LineId).HasMaxLength(50);

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.ProductName).HasMaxLength(500);

                entity.Property(e => e.ProductPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductTypeCode).HasMaxLength(50);

                entity.Property(e => e.ProductVolumetricWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ProductWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Productattr1)
                    .HasMaxLength(50)
                    .HasColumnName("productattr1");

                entity.Property(e => e.Productattr2)
                    .HasMaxLength(50)
                    .HasColumnName("productattr2");

                entity.Property(e => e.Productattr3)
                    .HasMaxLength(50)
                    .HasColumnName("productattr3");

                entity.Property(e => e.Productattr4)
                    .HasMaxLength(50)
                    .HasColumnName("productattr4");

                entity.Property(e => e.Productattr5)
                    .HasMaxLength(50)
                    .HasColumnName("productattr5");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Consignment)
                    .WithMany(p => p.ConsignmentDetails)
                    .HasForeignKey(d => d.ConsignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsignmentDetail_Consignment");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ConsignmentDetails)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_ShipmentDetail_Location");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key, "CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key).HasMaxLength(100);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MobilePhone).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Account");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Client");

                entity.HasOne(d => d.Consignment)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.ConsignmentId)
                    .HasConstraintName("FK_Customer_Shipment");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Location");
            });

            modelBuilder.Entity<CustomerSegment>(entity =>
            {
                entity.ToTable("CustomerSegment");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerSegments)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerSegment_Customer");

                entity.HasOne(d => d.Segment)
                    .WithMany(p => p.CustomerSegments)
                    .HasForeignKey(d => d.SegmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerSegment_Segment");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.ToTable("District");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ZipCode).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_District_City");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.TownId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Neighborhood_Town");
            });

            modelBuilder.Entity<DocumentTemplate>(entity =>
            {
                entity.ToTable("DocumentTemplate");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DataSource).HasMaxLength(50);

                entity.Property(e => e.DefaultPrinterName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.TypeLookup)
                    .WithMany(p => p.DocumentTemplates)
                    .HasForeignKey(d => d.TypeLookupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentTemplate_TypeLookup");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<IntegrationHistory>(entity =>
            {
                entity.ToTable("IntegrationHistory");

                entity.HasIndex(e => new { e.RecordStatusId, e.ChangedDate }, "Missing_IXNC_IntegrationHistory_RecordStatusId_ChangedDate_0FA7A");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TicketNumber).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.IntegrationHistories)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntegrationHistory_Account");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.IntegrationHistories)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntegrationHistory_Client");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.IntegrationHistories)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_IntegrationHistory_Location");

                entity.HasOne(d => d.StatusLookup)
                    .WithMany(p => p.IntegrationHistories)
                    .HasForeignKey(d => d.StatusLookupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntegrationHistory_StatusLookup");

                entity.HasOne(d => d.TypeLookup)
                    .WithMany(p => p.IntegrationHistories)
                    .HasForeignKey(d => d.TypeLookupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IntegrationHistory_TypeLookup");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameters)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobTracking>(entity =>
            {
                entity.ToTable("JobTracking");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastRunTime).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_Account");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_Client");

                entity.HasOne(d => d.LocationType)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.LocationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_TypeLookup");
            });

            modelBuilder.Entity<LocationCarrierConfiguration>(entity =>
            {
                entity.ToTable("LocationCarrierConfiguration");

                entity.Property(e => e.AdditionalZplisActive)
                    .HasColumnName("AdditionalZPLIsActive")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AdditionalZplisUseAsDefault).HasColumnName("AdditionalZPLIsUseAsDefault");

                entity.Property(e => e.AdditionalZpltemplate).HasColumnName("AdditionalZPLTemplate");

                entity.Property(e => e.ApiKey).HasMaxLength(500);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CheckIfPasswordIsMandatoryForQrcodeOnLabel).HasColumnName("CheckIfPasswordIsMandatoryForQRCodeOnLabel");

                entity.Property(e => e.CommonLabelUserName).HasMaxLength(50);

                entity.Property(e => e.CommonLabelUserPassword).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode).HasMaxLength(50);

                entity.Property(e => e.CustomerPrefix1).HasMaxLength(50);

                entity.Property(e => e.CustomerPrefix2).HasMaxLength(50);

                entity.Property(e => e.EwaybillActiveOnLabel).HasColumnName("EWaybillActiveOnLabel");

                entity.Property(e => e.EwaybillTemplateOnLabel).HasColumnName("EWaybillTemplateOnLabel");

                entity.Property(e => e.ExtraSettingValue1).HasMaxLength(100);

                entity.Property(e => e.ExtraSettingValue2).HasMaxLength(100);

                entity.Property(e => e.MarketPlaceCustomerToCustomerServicePassword).HasMaxLength(50);

                entity.Property(e => e.MarketPlaceCustomerToCustomerServiceUserName).HasMaxLength(50);

                entity.Property(e => e.MaxHeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxLength).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxWidth).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinHeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinLength).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinWidth).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PrintEdespatchOnLabel).HasColumnName("PrintEDespatchOnLabel");

                entity.Property(e => e.PutQrcodeOnLabelForEdespatch).HasColumnName("PutQRCodeOnLabelForEDespatch");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RmaServicePassword).HasMaxLength(50);

                entity.Property(e => e.RmaServiceUserName).HasMaxLength(50);

                entity.Property(e => e.RmacodeUsageLimit).HasColumnName("RMACodeUsageLimit");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.SenderCustomerAddressId).HasMaxLength(50);

                entity.Property(e => e.SenderCustomerId).HasMaxLength(50);

                entity.Property(e => e.TextForLabel).HasMaxLength(500);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.LocationCarrierConfigurations)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationCargoConfiguration_Account");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.LocationCarrierConfigurations)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationCargoConfiguration_Client");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationCarrierConfigurations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationCargoConfiguration_Location");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.LocationCarrierConfigurations)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_AccountCarrierConfiguration_TypeLookup");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.ToTable("Menu");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ParentMenu)
                    .WithMany(p => p.InverseParentMenu)
                    .HasForeignKey(d => d.ParentMenuId)
                    .HasConstraintName("FK_Menu_ParentMenu");
            });

            modelBuilder.Entity<OperationClaim>(entity =>
            {
                entity.ToTable("OperationClaim");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(250);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<OperationRole>(entity =>
            {
                entity.ToTable("OperationRole");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<OperationRoleOperationClaim>(entity =>
            {
                entity.ToTable("OperationRoleOperationClaim");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.OperationClaim)
                    .WithMany(p => p.OperationRoleOperationClaims)
                    .HasForeignKey(d => d.OperationClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperationRoleOperationClaim_OperationClaim");

                entity.HasOne(d => d.OperationRole)
                    .WithMany(p => p.OperationRoleOperationClaims)
                    .HasForeignKey(d => d.OperationRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperationRoleOperationClaim_OperationRole");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TotalPrice).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Order_Account");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK_Order_Client");
            });

            modelBuilder.Entity<PlannedShipmentWorkingSchedule>(entity =>
            {
                entity.ToTable("PlannedShipmentWorkingSchedule");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.AccountLocationWorkingSchedule)
                    .WithMany(p => p.PlannedShipmentWorkingSchedules)
                    .HasForeignKey(d => d.AccountLocationWorkingScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlannedShipmentWorkingSchedule_AccountWorkingSchedule");

                entity.HasOne(d => d.DeliverySlotType)
                    .WithMany(p => p.PlannedShipmentWorkingScheduleDeliverySlotTypes)
                    .HasForeignKey(d => d.DeliverySlotTypeId)
                    .HasConstraintName("FK_PlannedShipmentWorkingSchedule_TypeLookup1");

                entity.HasOne(d => d.DeliveryType)
                    .WithMany(p => p.PlannedShipmentWorkingScheduleDeliveryTypes)
                    .HasForeignKey(d => d.DeliveryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlannedShipmentWorkingSchedule_TypeLookup");
            });

            modelBuilder.Entity<ProcessGroup>(entity =>
            {
                entity.ToTable("ProcessGroup");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ProductConfiguration>(entity =>
            {
                entity.ToTable("ProductConfiguration");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductCode).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ProductConfigurations)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemConfiguration_Account");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ProductConfigurations)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_ProductConfiguration_City");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ProductConfigurations)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemConfiguration_Client");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ProductConfigurations)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_ProductConfiguration_Country");

                entity.HasOne(d => d.DefaultCarrier)
                    .WithMany(p => p.ProductConfigurations)
                    .HasForeignKey(d => d.DefaultCarrierId)
                    .HasConstraintName("FK_ItemConfiguration_Carrier");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.ProductConfigurations)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_ProductConfiguration_District");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ProductConfigurations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemConfiguration_Location");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.ProductConfigurations)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_ProductConfiguration_Town");
            });

            modelBuilder.Entity<Ptt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ptt");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.District)
                    .HasMaxLength(100)
                    .HasColumnName("district");

                entity.Property(e => e.Pk)
                    .HasMaxLength(50)
                    .HasColumnName("PK");

                entity.Property(e => e.Semt)
                    .HasMaxLength(50)
                    .HasColumnName("semt");

                entity.Property(e => e.Town)
                    .HasMaxLength(50)
                    .HasColumnName("town");

                entity.Property(e => e.TrimmedCity)
                    .HasMaxLength(100)
                    .HasColumnName("trimmedCity");

                entity.Property(e => e.TrimmedDistrict)
                    .HasMaxLength(100)
                    .HasColumnName("trimmedDistrict");

                entity.Property(e => e.TrimmedZipcode)
                    .HasMaxLength(100)
                    .HasColumnName("trimmedZipcode");
            });

            modelBuilder.Entity<ReportHistory>(entity =>
            {
                entity.ToTable("ReportHistory");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReportName).HasMaxLength(200);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.TicketNumber).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ReportHistories)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportHistory_Account");

                entity.HasOne(d => d.ChangeUserIdentity)
                    .WithMany(p => p.ReportHistoryChangeUserIdentities)
                    .HasForeignKey(d => d.ChangeUserIdentityId)
                    .HasConstraintName("FK_ReportHistory_UserIdentity1");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ReportHistories)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportHistory_Client");

                entity.HasOne(d => d.CreateUserIdentity)
                    .WithMany(p => p.ReportHistoryCreateUserIdentities)
                    .HasForeignKey(d => d.CreateUserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportHistory_UserIdentity");

                entity.HasOne(d => d.ReportHistoryStatus)
                    .WithMany(p => p.ReportHistories)
                    .HasForeignKey(d => d.ReportHistoryStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportHistory_StatusLookup");

                entity.HasOne(d => d.ReportHistoryType)
                    .WithMany(p => p.ReportHistories)
                    .HasForeignKey(d => d.ReportHistoryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportHistory_TypeLookup");

                entity.HasOne(d => d.ReportScript)
                    .WithMany(p => p.ReportHistories)
                    .HasForeignKey(d => d.ReportScriptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportHistory_ReportScript");
            });

            modelBuilder.Entity<ReportScript>(entity =>
            {
                entity.ToTable("ReportScript");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ReportScripts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportScript_Account");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ReportScripts)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportScript_Client");
            });

            modelBuilder.Entity<ReportScriptParameter>(entity =>
            {
                entity.ToTable("ReportScriptParameter");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ParameterText).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ParameterDataType)
                    .WithMany(p => p.ReportScriptParameterParameterDataTypes)
                    .HasForeignKey(d => d.ParameterDataTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportScriptParameter_TypeLookup");

                entity.HasOne(d => d.ParameterNameType)
                    .WithMany(p => p.ReportScriptParameterParameterNameTypes)
                    .HasForeignKey(d => d.ParameterNameTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportScriptParameter_TypeLookup1");

                entity.HasOne(d => d.ReportScript)
                    .WithMany(p => p.ReportScriptParameters)
                    .HasForeignKey(d => d.ReportScriptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportScriptParameter_ReportScript");
            });

            modelBuilder.Entity<Return>(entity =>
            {
                entity.ToTable("Return");

                entity.HasIndex(e => e.OrderId, "IX_Return_OrderId");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Reason).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ReturnCode).HasMaxLength(50);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Returns)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Return_Account");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.Returns)
                    .HasForeignKey(d => d.CarrierId)
                    .HasConstraintName("FK_Return_Carrier");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Returns)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Return_Consignment");
            });

            modelBuilder.Entity<ReturnItem>(entity =>
            {
                entity.ToTable("ReturnItem");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<RmaReason>(entity =>
            {
                entity.HasKey(e => e.ReasonId)
                    .HasName("PK_Reason");

                entity.ToTable("RmaReason");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ReasonName).HasMaxLength(70);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.ToTable("Route");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RouteName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Routes)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Route_FK");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Routes)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Route_FK_1");
            });

            modelBuilder.Entity<RouteLocation>(entity =>
            {
                entity.ToTable("RouteLocation");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.RouteLocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RouteLocation_FK");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.RouteLocations)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RouteLocation_FK_1");
            });

            modelBuilder.Entity<SalesChannel>(entity =>
            {
                entity.ToTable("SalesChannel");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Segment>(entity =>
            {
                entity.ToTable("Segment");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.Segments)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Segment_Carrier");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Segments)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Segment_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Segments)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Segment_Country");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Segments)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Segment_District");

                entity.HasOne(d => d.Town)
                    .WithMany(p => p.Segments)
                    .HasForeignKey(d => d.TownId)
                    .HasConstraintName("FK_Segment_Town");
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat, "IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score }, "IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.ToTable("Shipment");

                entity.HasIndex(e => new { e.CarrierId, e.ReturnId, e.RecordStatusId, e.ShipmentTypeId, e.ChangedDate }, "Missing_IXNC_Shipment_CarrierId_ReturnId_RecordStatusId_ShipmentTypeId_ChangedDate_11E9E");

                entity.Property(e => e.CalculatedShippingCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CalculatedShippingCustomerCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CargoResponse1).HasMaxLength(100);

                entity.Property(e => e.CargoResponse2).HasMaxLength(100);

                entity.Property(e => e.CarrierDeliveredTime).HasColumnType("datetime");

                entity.Property(e => e.CarrierGrossPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CarrierInitialTime).HasColumnType("datetime");

                entity.Property(e => e.CarrierKeyCreateTime).HasColumnType("datetime");

                entity.Property(e => e.CarrierNotDeliveredTime).HasColumnType("datetime");

                entity.Property(e => e.CarrierOnDeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.CarrierShipmentStatus).HasMaxLength(100);

                entity.Property(e => e.CarrierTrackingCode).HasMaxLength(100);

                entity.Property(e => e.CarrierVolumetricWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CarrierWeightKg).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentId).HasMaxLength(100);

                entity.Property(e => e.DocumentNumber).HasMaxLength(100);

                entity.Property(e => e.EstimatedDeliveryTime).HasColumnType("datetime");

                entity.Property(e => e.RealizedAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RealizedDeci).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ShipmentKey).HasMaxLength(100);

                entity.Property(e => e.ShipmentVolumetricWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ShipmentWeightKg).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TrackingNumber).HasMaxLength(100);

                entity.Property(e => e.TrackingUrl).HasMaxLength(500);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipment_Account1");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.CarrierId)
                    .HasConstraintName("FK_Delivery_Carrier");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shipment_Client1");

                entity.HasOne(d => d.Consignment)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.ConsignmentId)
                    .HasConstraintName("FK_Delivery_Consignment");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ShipmentLocations)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Delivery_Location");

                entity.HasOne(d => d.ShipmentStatus)
                    .WithMany(p => p.ShipmentShipmentStatuses)
                    .HasForeignKey(d => d.ShipmentStatusId)
                    .HasConstraintName("FK_Delivery_StatusLookup");

                entity.HasOne(d => d.SystemStatus)
                    .WithMany(p => p.ShipmentSystemStatuses)
                    .HasForeignKey(d => d.SystemStatusId)
                    .HasConstraintName("FK_Delivery_StatusLookup2");

                entity.HasOne(d => d.ToLocation)
                    .WithMany(p => p.ShipmentToLocations)
                    .HasForeignKey(d => d.ToLocationId)
                    .HasConstraintName("FK_ToLocationId");
            });

            modelBuilder.Entity<ShipmentCarrierHistory>(entity =>
            {
                entity.ToTable("ShipmentCarrierHistory");

                entity.Property(e => e.ArrivalCenter).HasMaxLength(50);

                entity.Property(e => e.BranchOffice).HasMaxLength(50);

                entity.Property(e => e.CarrierEmployeeName).HasMaxLength(50);

                entity.Property(e => e.CarrierEventTime).HasColumnType("datetime");

                entity.Property(e => e.CarrierKey).HasMaxLength(50);

                entity.Property(e => e.CarrierStatus).HasMaxLength(50);

                entity.Property(e => e.CarrierTrackingNumber).HasMaxLength(50);

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromLocation).HasMaxLength(50);

                entity.Property(e => e.ReasonDescription).HasMaxLength(50);

                entity.Property(e => e.ReasonId).HasMaxLength(50);

                entity.Property(e => e.ReceivedTime).HasColumnType("datetime");

                entity.Property(e => e.RecipientName).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ShipmentRemarks).HasMaxLength(50);

                entity.Property(e => e.ToLocation).HasMaxLength(50);

                entity.Property(e => e.TownName).HasMaxLength(50);

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentCarrierHistories)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK_Del_Delivery");
            });

            modelBuilder.Entity<ShipmentDeliveryReceipt>(entity =>
            {
                entity.ToTable("ShipmentDeliveryReceipt");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ShipmentDeliveryReceipts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentDeliveryReceipt_Account1");

                entity.HasOne(d => d.Car)
                    .WithMany(p => p.ShipmentDeliveryReceipts)
                    .HasForeignKey(d => d.CarId)
                    .HasConstraintName("FK_CarId");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.ShipmentDeliveryReceipts)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentDeliveryReceipt_Carrier");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ShipmentDeliveryReceipts)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentDeliveryReceipt_Client1");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.ShipmentDeliveryReceipts)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_RouteId");

                entity.HasOne(d => d.ShipmentDeliveryReceiptStatus)
                    .WithMany(p => p.ShipmentDeliveryReceipts)
                    .HasForeignKey(d => d.ShipmentDeliveryReceiptStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentDeliveryReceipt_ShipmentDeliveryReceiptStatusId");

                entity.HasOne(d => d.ShipmentDeliveryReceiptType)
                    .WithMany(p => p.ShipmentDeliveryReceipts)
                    .HasForeignKey(d => d.ShipmentDeliveryReceiptTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentDeliveryReceipt_ShipmentDeliveryReceiptTypeId");
            });

            modelBuilder.Entity<ShipmentDeliveryReceiptLine>(entity =>
            {
                entity.ToTable("ShipmentDeliveryReceiptLine");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ShipmentDeliveryReceiptLines)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentDelivieryReceiptLine_AccountId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ShipmentDeliveryReceiptLines)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentDelivieryReceiptLine_ClientId");

                entity.HasOne(d => d.ShipmentDeliveryReceipt)
                    .WithMany(p => p.ShipmentDeliveryReceiptLines)
                    .HasForeignKey(d => d.ShipmentDeliveryReceiptId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ShipmentDeliveryReceiptLine_FK");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentDeliveryReceiptLines)
                    .HasForeignKey(d => d.ShipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentId");
            });

            modelBuilder.Entity<ShipmentDetail>(entity =>
            {
                entity.ToTable("ShipmentDetail");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerShipmentNumber).HasMaxLength(100);

                entity.Property(e => e.CustomerSpecificCode).HasMaxLength(50);

                entity.Property(e => e.LabelSequenceNumber).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.VolumetricWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WeightKg).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentDetails)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK_DeliveryDetail_Delivery");
            });

            modelBuilder.Entity<ShipmentDetailLine>(entity =>
            {
                entity.ToTable("ShipmentDetailLine");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerSpecificCode).HasMaxLength(50);

                entity.Property(e => e.LineId).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ShipmentDocument>(entity =>
            {
                entity.ToTable("ShipmentDocument");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentDocuments)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK_ShipmentDocument_Shipment");
            });

            modelBuilder.Entity<ShipmentHistory>(entity =>
            {
                entity.ToTable("ShipmentHistory");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentHistories)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK_DeliveryHistory_Delivery");
            });

            modelBuilder.Entity<ShipmentPattern>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ShipmentPattern");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Counter).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Desi).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.PatternContent).HasMaxLength(150);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ShipmentPatternId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Account)
                    .WithMany()
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentPattern_Account1");

                entity.HasOne(d => d.Carrier)
                    .WithMany()
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentPattern_Carrier");

                entity.HasOne(d => d.Client)
                    .WithMany()
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipmentPattern_Client1");
            });

            modelBuilder.Entity<ShipmentStatusMapping>(entity =>
            {
                entity.ToTable("ShipmentStatusMapping");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.ShipmentStatusMappings)
                    .HasForeignKey(d => d.CarrierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeliveryStatusMapping_Carrier");

                entity.HasOne(d => d.ShipmentStatus)
                    .WithMany(p => p.ShipmentStatusMappings)
                    .HasForeignKey(d => d.ShipmentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeliveryStatusMapping_StatusLookup");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<StatusLookup>(entity =>
            {
                entity.ToTable("StatusLookup");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ProcessGroup)
                    .WithMany(p => p.StatusLookups)
                    .HasForeignKey(d => d.ProcessGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StatusLookup_ProcessGroup");
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.ToTable("Town");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Towns)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Town_City");
            });

            modelBuilder.Entity<TypeLookup>(entity =>
            {
                entity.ToTable("TypeLookup");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ProcessGroup)
                    .WithMany(p => p.TypeLookups)
                    .HasForeignKey(d => d.ProcessGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TypeLookup_ProcessGroup");
            });

            modelBuilder.Entity<UserIdentity>(entity =>
            {
                entity.ToTable("UserIdentity");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IdentityNumber).HasMaxLength(20);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.PasswordHash).HasMaxLength(500);

                entity.Property(e => e.PasswordSalt).HasMaxLength(500);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RefreshToken).HasMaxLength(500);

                entity.Property(e => e.RefreshTokenEndDate).HasColumnType("datetime");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.ChangeUserIdentity)
                    .WithMany(p => p.InverseChangeUserIdentity)
                    .HasForeignKey(d => d.ChangeUserIdentityId)
                    .HasConstraintName("FK_UserIdentity_UserIdentity1");

                entity.HasOne(d => d.CreateUserIdentity)
                    .WithMany(p => p.InverseCreateUserIdentity)
                    .HasForeignKey(d => d.CreateUserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentity_UserIdentity");
            });

            modelBuilder.Entity<UserIdentityAccount>(entity =>
            {
                entity.ToTable("UserIdentityAccount");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.UserIdentityAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityAccount_Account");

                entity.HasOne(d => d.ChangeUserIdentity)
                    .WithMany(p => p.UserIdentityAccountChangeUserIdentities)
                    .HasForeignKey(d => d.ChangeUserIdentityId)
                    .HasConstraintName("FK_UserIdentityAccount_UserIdentity2");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserIdentityAccounts)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityAccount_Client");

                entity.HasOne(d => d.CreateUserIdentity)
                    .WithMany(p => p.UserIdentityAccountCreateUserIdentities)
                    .HasForeignKey(d => d.CreateUserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityAccount_UserIdentity1");

                entity.HasOne(d => d.UserIdentity)
                    .WithMany(p => p.UserIdentityAccountUserIdentities)
                    .HasForeignKey(d => d.UserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityAccount_UserIdentity");
            });

            modelBuilder.Entity<UserIdentityClient>(entity =>
            {
                entity.ToTable("UserIdentityClient");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ChangeUserIdentity)
                    .WithMany(p => p.UserIdentityClientChangeUserIdentities)
                    .HasForeignKey(d => d.ChangeUserIdentityId)
                    .HasConstraintName("FK_UserIdentityClient_UserIdentity2");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserIdentityClients)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityClient_Client");

                entity.HasOne(d => d.CreateUserIdentity)
                    .WithMany(p => p.UserIdentityClientCreateUserIdentities)
                    .HasForeignKey(d => d.CreateUserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityClient_UserIdentity1");

                entity.HasOne(d => d.UserIdentity)
                    .WithMany(p => p.UserIdentityClientUserIdentities)
                    .HasForeignKey(d => d.UserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityClient_UserIdentity");
            });

            modelBuilder.Entity<UserIdentityLocation>(entity =>
            {
                entity.ToTable("UserIdentityLocation");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.UserIdentityLocations)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityLocation_Account");

                entity.HasOne(d => d.ChangeUserIdentity)
                    .WithMany(p => p.UserIdentityLocationChangeUserIdentities)
                    .HasForeignKey(d => d.ChangeUserIdentityId)
                    .HasConstraintName("FK_UserIdentityLocation_UserIdentity2");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.UserIdentityLocations)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityLocation_Client");

                entity.HasOne(d => d.CreateUserIdentity)
                    .WithMany(p => p.UserIdentityLocationCreateUserIdentities)
                    .HasForeignKey(d => d.CreateUserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityLocation_UserIdentity1");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.UserIdentityLocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityLocation_Location");

                entity.HasOne(d => d.UserIdentity)
                    .WithMany(p => p.UserIdentityLocationUserIdentities)
                    .HasForeignKey(d => d.UserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityLocation_UserIdentity");
            });

            modelBuilder.Entity<UserIdentityOperationClaim>(entity =>
            {
                entity.ToTable("UserIdentityOperationClaim");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ChangeUserIdentity)
                    .WithMany(p => p.UserIdentityOperationClaimChangeUserIdentities)
                    .HasForeignKey(d => d.ChangeUserIdentityId)
                    .HasConstraintName("FK_UserIdentityOperationClaim_UserIdentity2");

                entity.HasOne(d => d.CreateUserIdentity)
                    .WithMany(p => p.UserIdentityOperationClaimCreateUserIdentities)
                    .HasForeignKey(d => d.CreateUserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityOperationClaim_UserIdentity1");

                entity.HasOne(d => d.OperationClaim)
                    .WithMany(p => p.UserIdentityOperationClaims)
                    .HasForeignKey(d => d.OperationClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityOperationClaim_OperationClaim");

                entity.HasOne(d => d.UserIdentity)
                    .WithMany(p => p.UserIdentityOperationClaimUserIdentities)
                    .HasForeignKey(d => d.UserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityOperationClaim_UserIdentity");
            });

            modelBuilder.Entity<UserIdentityOperationRole>(entity =>
            {
                entity.ToTable("UserIdentityOperationRole");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.ChangeUserIdentity)
                    .WithMany(p => p.UserIdentityOperationRoleChangeUserIdentities)
                    .HasForeignKey(d => d.ChangeUserIdentityId)
                    .HasConstraintName("FK_UserIdentityOperationRole_UserIdentity2");

                entity.HasOne(d => d.CreateUserIdentity)
                    .WithMany(p => p.UserIdentityOperationRoleCreateUserIdentities)
                    .HasForeignKey(d => d.CreateUserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityOperationRole_UserIdentity1");

                entity.HasOne(d => d.OperationRole)
                    .WithMany(p => p.UserIdentityOperationRoles)
                    .HasForeignKey(d => d.OperationRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityOperationRole_OperationRole");

                entity.HasOne(d => d.UserIdentity)
                    .WithMany(p => p.UserIdentityOperationRoleUserIdentities)
                    .HasForeignKey(d => d.UserIdentityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserIdentityOperationRole_UserIdentity");
            });

            modelBuilder.Entity<ValueMapping>(entity =>
            {
                entity.ToTable("ValueMapping");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.ValueKeyText).HasMaxLength(50);

                entity.Property(e => e.ValueMatchingText).HasMaxLength(100);
            });

            modelBuilder.Entity<WebHookSubscription>(entity =>
            {
                entity.ToTable("WebHookSubscription");

                entity.Property(e => e.ChangedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.RecordStatusId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.UserName).HasMaxLength(20);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.WebHookSubscriptions)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebHookSubscription_AccountId");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.WebHookSubscriptions)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebHookSubscription_ClientId");
            });

            modelBuilder.HasSequence("ConsignmentNumberSequence").StartsAt(100001);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
