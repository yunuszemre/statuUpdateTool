using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class AccountLocationWorkingSchedule
    {
        public AccountLocationWorkingSchedule()
        {
            PlannedShipmentWorkingSchedules = new HashSet<PlannedShipmentWorkingSchedule>();
        }

        public long AccountLocationWorkingScheduleId { get; set; }
        public long AccountId { get; set; }
        public long? CarrierId { get; set; }
        public long? WeekDayTypeId { get; set; }
        public bool? IsActive { get; set; }
        public long? WorkingScheduleGroupId { get; set; }
        public string? WorkingScheduleDescription { get; set; }
        public long? OperationCutOffTime { get; set; }
        public long? DaysToAdd { get; set; }
        public bool? IfPlannedShipment { get; set; }
        public bool? IsDefault { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Carrier? Carrier { get; set; }
        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual TypeLookup? WeekDayType { get; set; }
        public virtual ICollection<PlannedShipmentWorkingSchedule> PlannedShipmentWorkingSchedules { get; set; }
    }
}
