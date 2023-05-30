using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class Address
    {
        public long AddressId { get; set; }
        public string? AddressCode { get; set; }
        public long ClientId { get; set; }
        public long? AccountId { get; set; }
        public long? LocationId { get; set; }
        public long TypeLookupId { get; set; }
        public long? CustomerId { get; set; }
        public long CountryId { get; set; }
        public long CityId { get; set; }
        public long? TownId { get; set; }
        public long? DistrictId { get; set; }
        public string? AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string? ZipCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account? Account { get; set; }
        public virtual City City { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual Country Country { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual Location? Location { get; set; }
        public virtual Town? Town { get; set; }
        public virtual TypeLookup TypeLookup { get; set; } = null!;
    }
}
