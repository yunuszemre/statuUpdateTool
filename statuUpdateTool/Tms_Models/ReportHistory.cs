using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ReportHistory
    {
        public long ReportHistoryId { get; set; }
        public long ReportScriptId { get; set; }
        public string TicketNumber { get; set; } = null!;
        public string? ReportName { get; set; }
        public long ReportHistoryTypeId { get; set; }
        public long ReportHistoryStatusId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public string Request { get; set; } = null!;
        public string? Result { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual StatusLookup ReportHistoryStatus { get; set; } = null!;
        public virtual TypeLookup ReportHistoryType { get; set; } = null!;
        public virtual ReportScript ReportScript { get; set; } = null!;
    }
}
