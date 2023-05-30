using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class UserIdentityLocation
    {
        public long UserIdentityLocationId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long LocationId { get; set; }
        public long UserIdentityId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public bool? IsStoreUser { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual Client Client { get; set; } = null!;
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual Location Location { get; set; } = null!;
        public virtual UserIdentity UserIdentity { get; set; } = null!;
    }
}
