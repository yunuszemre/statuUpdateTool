using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ReportScript
    {
        public ReportScript()
        {
            ReportHistories = new HashSet<ReportHistory>();
            ReportScriptParameters = new HashSet<ReportScriptParameter>();
        }

        public long ReportScriptId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public string? Script { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<ReportHistory> ReportHistories { get; set; }
        public virtual ICollection<ReportScriptParameter> ReportScriptParameters { get; set; }
    }
}
