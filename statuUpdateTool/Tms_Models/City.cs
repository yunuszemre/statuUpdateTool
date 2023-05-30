using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class City
    {
        public City()
        {
            AccountCarrierBlacklists = new HashSet<AccountCarrierBlacklist>();
            AccountDecisionRules = new HashSet<AccountDecisionRule>();
            AccountServiceTypeRules = new HashSet<AccountServiceTypeRule>();
            Addresses = new HashSet<Address>();
            CarrierDeliveryTypes = new HashSet<CarrierDeliveryType>();
            CarrierDistanceBetweenCityGroupFromCities = new HashSet<CarrierDistanceBetweenCityGroup>();
            CarrierDistanceBetweenCityGroupToCities = new HashSet<CarrierDistanceBetweenCityGroup>();
            CarrierRouteMappings = new HashSet<CarrierRouteMapping>();
            CarrierValueMappings = new HashSet<CarrierValueMapping>();
            Carriers = new HashSet<Carrier>();
            ClientValueMappings = new HashSet<ClientValueMapping>();
            Districts = new HashSet<District>();
            ProductConfigurations = new HashSet<ProductConfiguration>();
            Segments = new HashSet<Segment>();
            Towns = new HashSet<Town>();
        }

        public long CityId { get; set; }
        public long CountryId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<AccountCarrierBlacklist> AccountCarrierBlacklists { get; set; }
        public virtual ICollection<AccountDecisionRule> AccountDecisionRules { get; set; }
        public virtual ICollection<AccountServiceTypeRule> AccountServiceTypeRules { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CarrierDeliveryType> CarrierDeliveryTypes { get; set; }
        public virtual ICollection<CarrierDistanceBetweenCityGroup> CarrierDistanceBetweenCityGroupFromCities { get; set; }
        public virtual ICollection<CarrierDistanceBetweenCityGroup> CarrierDistanceBetweenCityGroupToCities { get; set; }
        public virtual ICollection<CarrierRouteMapping> CarrierRouteMappings { get; set; }
        public virtual ICollection<CarrierValueMapping> CarrierValueMappings { get; set; }
        public virtual ICollection<Carrier> Carriers { get; set; }
        public virtual ICollection<ClientValueMapping> ClientValueMappings { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<ProductConfiguration> ProductConfigurations { get; set; }
        public virtual ICollection<Segment> Segments { get; set; }
        public virtual ICollection<Town> Towns { get; set; }
    }
}
