using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class CarrierDeliveryType
    {
        public long CarrierDeliveryTypeId { get; set; }
        public long CarrierId { get; set; }
        public long DeliveryTypeId { get; set; }
        public long? DeliverySlotTypeId { get; set; }
        public long CountryId { get; set; }
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

        public virtual Carrier Carrier { get; set; } = null!;
        public virtual City? City { get; set; }
        public virtual Country Country { get; set; } = null!;
        public virtual TypeLookup? DeliverySlotType { get; set; }
        public virtual District? District { get; set; }
        public virtual Town? Town { get; set; }
    }
}
