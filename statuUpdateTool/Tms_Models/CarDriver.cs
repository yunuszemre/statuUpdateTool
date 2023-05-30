using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class CarDriver
    {
        public long CarDriverId { get; set; }
        public long RouteId { get; set; }
        public long CarId { get; set; }
        public long DriverId { get; set; }
        public long AccountId { get; set; }
        public long ClientId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public bool IfTransferredToSecondary { get; set; }
        public byte[]? RowVersion { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Car Car { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual Route Route { get; set; } = null!;
    }
}
