using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class JobTracking
    {
        public long JobTrackingId { get; set; }
        public string? Code { get; set; }
        public DateTime LastRunTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
    }
}
