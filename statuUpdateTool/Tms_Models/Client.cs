using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class Client
    {
        public Client()
        {
            AccountCriteriaPriorityMappings = new HashSet<AccountCriteriaPriorityMapping>();
            AccountDecisionRules = new HashSet<AccountDecisionRule>();
            AccountSalesChannelConfigurations = new HashSet<AccountSalesChannelConfiguration>();
            AccountServiceTypeRules = new HashSet<AccountServiceTypeRule>();
            Accounts = new HashSet<Account>();
            Addresses = new HashSet<Address>();
            CarDrivers = new HashSet<CarDriver>();
            CarrierValueMappings = new HashSet<CarrierValueMapping>();
            Cars = new HashSet<Car>();
            ClientValueMappings = new HashSet<ClientValueMapping>();
            ConsignmentConfigurations = new HashSet<ConsignmentConfiguration>();
            Consignments = new HashSet<Consignment>();
            Customers = new HashSet<Customer>();
            IntegrationHistories = new HashSet<IntegrationHistory>();
            LocationCarrierConfigurations = new HashSet<LocationCarrierConfiguration>();
            Locations = new HashSet<Location>();
            Orders = new HashSet<Order>();
            ProductConfigurations = new HashSet<ProductConfiguration>();
            ReportHistories = new HashSet<ReportHistory>();
            ReportScripts = new HashSet<ReportScript>();
            Routes = new HashSet<Route>();
            ShipmentDeliveryReceiptLines = new HashSet<ShipmentDeliveryReceiptLine>();
            ShipmentDeliveryReceipts = new HashSet<ShipmentDeliveryReceipt>();
            Shipments = new HashSet<Shipment>();
            UserIdentityAccounts = new HashSet<UserIdentityAccount>();
            UserIdentityClients = new HashSet<UserIdentityClient>();
            UserIdentityLocations = new HashSet<UserIdentityLocation>();
            WebHookSubscriptions = new HashSet<WebHookSubscription>();
        }

        public long ClientId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool? IfRecordVersioningTurnedOff { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public bool? IfAsynchronousRecordingIsOff { get; set; }

        public virtual ICollection<AccountCriteriaPriorityMapping> AccountCriteriaPriorityMappings { get; set; }
        public virtual ICollection<AccountDecisionRule> AccountDecisionRules { get; set; }
        public virtual ICollection<AccountSalesChannelConfiguration> AccountSalesChannelConfigurations { get; set; }
        public virtual ICollection<AccountServiceTypeRule> AccountServiceTypeRules { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CarDriver> CarDrivers { get; set; }
        public virtual ICollection<CarrierValueMapping> CarrierValueMappings { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<ClientValueMapping> ClientValueMappings { get; set; }
        public virtual ICollection<ConsignmentConfiguration> ConsignmentConfigurations { get; set; }
        public virtual ICollection<Consignment> Consignments { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<IntegrationHistory> IntegrationHistories { get; set; }
        public virtual ICollection<LocationCarrierConfiguration> LocationCarrierConfigurations { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductConfiguration> ProductConfigurations { get; set; }
        public virtual ICollection<ReportHistory> ReportHistories { get; set; }
        public virtual ICollection<ReportScript> ReportScripts { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
        public virtual ICollection<ShipmentDeliveryReceiptLine> ShipmentDeliveryReceiptLines { get; set; }
        public virtual ICollection<ShipmentDeliveryReceipt> ShipmentDeliveryReceipts { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
        public virtual ICollection<UserIdentityAccount> UserIdentityAccounts { get; set; }
        public virtual ICollection<UserIdentityClient> UserIdentityClients { get; set; }
        public virtual ICollection<UserIdentityLocation> UserIdentityLocations { get; set; }
        public virtual ICollection<WebHookSubscription> WebHookSubscriptions { get; set; }
    }
}
