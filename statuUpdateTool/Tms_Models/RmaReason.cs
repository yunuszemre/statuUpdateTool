using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class RmaReason
    {
        public long ReasonId { get; set; }
        public string? ReasonName { get; set; }
        public long? ClientId { get; set; }
        public long? AccountId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[]? RowVersion { get; set; }
        public bool IfTransferredToSecondary { get; set; }
    }
}
