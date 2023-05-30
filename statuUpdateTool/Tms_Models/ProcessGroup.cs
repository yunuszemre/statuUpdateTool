using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ProcessGroup
    {
        public ProcessGroup()
        {
            StatusLookups = new HashSet<StatusLookup>();
            TypeLookups = new HashSet<TypeLookup>();
        }

        public long ProcessGroupId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual ICollection<StatusLookup> StatusLookups { get; set; }
        public virtual ICollection<TypeLookup> TypeLookups { get; set; }
    }
}
