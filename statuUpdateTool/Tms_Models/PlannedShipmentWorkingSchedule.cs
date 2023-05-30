using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class PlannedShipmentWorkingSchedule
    {
        public long PlannedShipmentWorkingScheduleId { get; set; }
        public long AccountLocationWorkingScheduleId { get; set; }
        public long DeliveryTypeId { get; set; }
        public long? DeliverySlotTypeId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual AccountLocationWorkingSchedule AccountLocationWorkingSchedule { get; set; } = null!;
        public virtual TypeLookup? DeliverySlotType { get; set; }
        public virtual TypeLookup DeliveryType { get; set; } = null!;
    }
}
