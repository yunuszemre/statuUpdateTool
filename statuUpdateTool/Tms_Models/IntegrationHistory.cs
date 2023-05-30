using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class IntegrationHistory
    {
        public long IntegrationHistoryId { get; set; }
        public string TicketNumber { get; set; } = null!;
        public long TypeLookupId { get; set; }
        public long StatusLookupId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long? LocationId { get; set; }
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
        public virtual Client Client { get; set; } = null!;
        public virtual Location? Location { get; set; }
        public virtual StatusLookup StatusLookup { get; set; } = null!;
        public virtual TypeLookup TypeLookup { get; set; } = null!;
    }
}
