using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class CustomerSegment
    {
        public long CustomerSegmentId { get; set; }
        public long SegmentId { get; set; }
        public long CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Segment Segment { get; set; } = null!;
    }
}
