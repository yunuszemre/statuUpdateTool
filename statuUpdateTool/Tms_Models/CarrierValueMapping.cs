using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class CarrierValueMapping
    {
        public long CarrierValueMappingId { get; set; }
        public long? AccountId { get; set; }
        public long ClientId { get; set; }
        public long CarrierId { get; set; }
        public string? CarrierCountryCode { get; set; }
        public string? CarrierCityCode { get; set; }
        public string? CarrierTownCode { get; set; }
        public string? CarrierDistrictCode { get; set; }
        public string? CarrierZipCode { get; set; }
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? TownId { get; set; }
        public long? DistrictId { get; set; }
        public string? ZipCode { get; set; }
        public bool? IsMatched { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public long? CarrierCountryId { get; set; }
        public long? CarrierCityId { get; set; }
        public long? CarrierTownId { get; set; }
        public long? CarrierDistrictId { get; set; }

        public virtual Account? Account { get; set; }
        public virtual City? City { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual Country? Country { get; set; }
        public virtual District? District { get; set; }
        public virtual Town? Town { get; set; }
    }
}
