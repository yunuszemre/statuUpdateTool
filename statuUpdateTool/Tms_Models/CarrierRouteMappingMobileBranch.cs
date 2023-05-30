using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class CarrierRouteMappingMobileBranch
    {
        public long CarrierRouteMappingMobileBranchId { get; set; }
        public long CarrierRouteMappingId { get; set; }
        public long? DelayValue { get; set; }
        public long? DayValueOfWeek { get; set; }
        public long? DeliverySlotTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual CarrierRouteMapping CarrierRouteMapping { get; set; } = null!;
        public virtual TypeLookup? DeliverySlotType { get; set; }
    }
}
