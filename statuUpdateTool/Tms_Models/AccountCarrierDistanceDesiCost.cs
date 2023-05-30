using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class AccountCarrierDistanceDesiCost
    {
        public long AccountCarrierDistanceDesiCostId { get; set; }
        public long AccountId { get; set; }
        public long CarrierId { get; set; }
        public long CarrierDistanceLookupId { get; set; }
        public int? EstimatedDeliveryTime { get; set; }
        public decimal? Cost { get; set; }
        public decimal? CustomerCost { get; set; }
        public decimal? MinWidth { get; set; }
        public decimal? MaxWidth { get; set; }
        public decimal? MinLength { get; set; }
        public decimal? MaxLength { get; set; }
        public decimal? MinHeight { get; set; }
        public decimal? MaxHeight { get; set; }
        public decimal? MinWeight { get; set; }
        public decimal? MaxWeight { get; set; }
        public decimal? MinDesi { get; set; }
        public decimal? MaxDesi { get; set; }
        public bool? IsDefault { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public bool? IfSelectedPlusDesi { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Carrier Carrier { get; set; } = null!;
        public virtual CarrierDistanceLookup CarrierDistanceLookup { get; set; } = null!;
    }
}
