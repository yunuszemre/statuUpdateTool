using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class Return
    {
        public long ReturnId { get; set; }
        public string? ReturnCode { get; set; }
        public long AccountId { get; set; }
        public long? OrderId { get; set; }
        public long? CarrierId { get; set; }
        public long? LocationId { get; set; }
        public int? ReturnCodeMaxUsageCount { get; set; }
        public string? Reason { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Carrier? Carrier { get; set; }
        public virtual Consignment? Order { get; set; }
    }
}
