using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class RouteLocation
    {
        public long RouteLocationId { get; set; }
        public long RouteId { get; set; }
        public long LocationId { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long CreateUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public DateTime? ChangedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? SortNumber { get; set; }

        public virtual Location Location { get; set; } = null!;
        public virtual Route Route { get; set; } = null!;
    }
}
