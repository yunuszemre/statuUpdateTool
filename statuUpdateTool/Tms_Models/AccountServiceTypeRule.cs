using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class AccountServiceTypeRule
    {
        public long AccountServiceTypeRuleId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long LocationId { get; set; }
        public long CarrierId { get; set; }
        public int? Priority { get; set; }
        public long CountryId { get; set; }
        public long? CityId { get; set; }
        public long? TownId { get; set; }
        public long? DistrictId { get; set; }
        public long? PaymentTypeId { get; set; }
        public long? DeliveryTypeId { get; set; }
        public long? DeliverySlotTypeId { get; set; }
        public int? EstimatedDeliveryTime { get; set; }
        public int? CutOffHour { get; set; }
        public long? Cost { get; set; }
        public long? CustomerCost { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Carrier Carrier { get; set; } = null!;
        public virtual City? City { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual Country Country { get; set; } = null!;
        public virtual TypeLookup? DeliverySlotType { get; set; }
        public virtual TypeLookup? DeliveryType { get; set; }
        public virtual District? District { get; set; }
        public virtual Location Location { get; set; } = null!;
        public virtual TypeLookup? PaymentType { get; set; }
        public virtual Town? Town { get; set; }
    }
}
