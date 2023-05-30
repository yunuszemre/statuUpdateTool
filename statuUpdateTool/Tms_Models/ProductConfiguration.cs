using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ProductConfiguration
    {
        public long ProductConfigurationId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long LocationId { get; set; }
        public string ProductCode { get; set; } = null!;
        public long? DefaultCarrierId { get; set; }
        public bool? IfFragileLabelExists { get; set; }
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? TownId { get; set; }
        public long? DistrictId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual City? City { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual Country? Country { get; set; }
        public virtual Carrier? DefaultCarrier { get; set; }
        public virtual District? District { get; set; }
        public virtual Location Location { get; set; } = null!;
        public virtual Town? Town { get; set; }
    }
}
