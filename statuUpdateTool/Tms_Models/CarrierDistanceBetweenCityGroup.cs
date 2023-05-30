using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class CarrierDistanceBetweenCityGroup
    {
        public long CarrierDistanceBetweenCityGroupId { get; set; }
        public long CarrierId { get; set; }
        public long DistanceTypeId { get; set; }
        public long? CityGroupTypeId { get; set; }
        public long? FromCityId { get; set; }
        public long? ToCityId { get; set; }
        public long? CarrierDistanceLookupId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Carrier Carrier { get; set; } = null!;
        public virtual CarrierDistanceLookup? CarrierDistanceLookup { get; set; }
        public virtual TypeLookup? CityGroupType { get; set; }
        public virtual TypeLookup DistanceType { get; set; } = null!;
        public virtual City? FromCity { get; set; }
        public virtual City? ToCity { get; set; }
    }
}
