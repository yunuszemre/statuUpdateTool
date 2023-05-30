using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class Carrier
    {
        public Carrier()
        {
            AccountCarrierBlacklists = new HashSet<AccountCarrierBlacklist>();
            AccountCarrierDistanceDesiCosts = new HashSet<AccountCarrierDistanceDesiCost>();
            AccountDecisionRules = new HashSet<AccountDecisionRule>();
            AccountLocationWorkingSchedules = new HashSet<AccountLocationWorkingSchedule>();
            AccountServiceTypeRules = new HashSet<AccountServiceTypeRule>();
            CarrierDeliveryTypes = new HashSet<CarrierDeliveryType>();
            CarrierDistanceBetweenCityGroups = new HashSet<CarrierDistanceBetweenCityGroup>();
            CarrierDistanceLookups = new HashSet<CarrierDistanceLookup>();
            CarrierRouteMappings = new HashSet<CarrierRouteMapping>();
            CarrierShipmentStatusNotMatches = new HashSet<CarrierShipmentStatusNotMatch>();
            CarrierShipmentStatuses = new HashSet<CarrierShipmentStatus>();
            ConsignmentConfigurations = new HashSet<ConsignmentConfiguration>();
            Consignments = new HashSet<Consignment>();
            ProductConfigurations = new HashSet<ProductConfiguration>();
            Returns = new HashSet<Return>();
            Segments = new HashSet<Segment>();
            ShipmentDeliveryReceipts = new HashSet<ShipmentDeliveryReceipt>();
            ShipmentStatusMappings = new HashSet<ShipmentStatusMapping>();
            Shipments = new HashSet<Shipment>();
        }

        public long CarrierId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? TownId { get; set; }
        public long? DistrictId { get; set; }
        public string? AddressLine { get; set; }
        public string? ZipCode { get; set; }
        public string? TaxCode { get; set; }
        public string? TaxNumber { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool? IsNationalCarrier { get; set; }
        public bool? IsDistanceMetric { get; set; }
        public bool? CodcashSupport { get; set; }
        public bool? CodcreditCardSupport { get; set; }
        public bool? RmaSupport { get; set; }
        public bool? SalesChannelSupport { get; set; }
        public bool? NotWorkOffline { get; set; }
        public string? ServiceUrl { get; set; }
        public string? StatusServiceUrl { get; set; }
        public string? ReturnServiceUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public bool? MarketPlaceCustomerToCustomerSupport { get; set; }
        public string? MarketPlaceCustomerToCustomerServiceUrl { get; set; }

        public virtual City? City { get; set; }
        public virtual Country? Country { get; set; }
        public virtual District? District { get; set; }
        public virtual Town? Town { get; set; }
        public virtual ICollection<AccountCarrierBlacklist> AccountCarrierBlacklists { get; set; }
        public virtual ICollection<AccountCarrierDistanceDesiCost> AccountCarrierDistanceDesiCosts { get; set; }
        public virtual ICollection<AccountDecisionRule> AccountDecisionRules { get; set; }
        public virtual ICollection<AccountLocationWorkingSchedule> AccountLocationWorkingSchedules { get; set; }
        public virtual ICollection<AccountServiceTypeRule> AccountServiceTypeRules { get; set; }
        public virtual ICollection<CarrierDeliveryType> CarrierDeliveryTypes { get; set; }
        public virtual ICollection<CarrierDistanceBetweenCityGroup> CarrierDistanceBetweenCityGroups { get; set; }
        public virtual ICollection<CarrierDistanceLookup> CarrierDistanceLookups { get; set; }
        public virtual ICollection<CarrierRouteMapping> CarrierRouteMappings { get; set; }
        public virtual ICollection<CarrierShipmentStatusNotMatch> CarrierShipmentStatusNotMatches { get; set; }
        public virtual ICollection<CarrierShipmentStatus> CarrierShipmentStatuses { get; set; }
        public virtual ICollection<ConsignmentConfiguration> ConsignmentConfigurations { get; set; }
        public virtual ICollection<Consignment> Consignments { get; set; }
        public virtual ICollection<ProductConfiguration> ProductConfigurations { get; set; }
        public virtual ICollection<Return> Returns { get; set; }
        public virtual ICollection<Segment> Segments { get; set; }
        public virtual ICollection<ShipmentDeliveryReceipt> ShipmentDeliveryReceipts { get; set; }
        public virtual ICollection<ShipmentStatusMapping> ShipmentStatusMappings { get; set; }
        public virtual ICollection<Shipment> Shipments { get; set; }
    }
}
