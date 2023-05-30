using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class UserIdentityOperationClaim
    {
        public long UserIdentityOperationClaimId { get; set; }
        public long UserIdentityId { get; set; }
        public long OperationClaimId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual OperationClaim OperationClaim { get; set; } = null!;
        public virtual UserIdentity UserIdentity { get; set; } = null!;
    }
}
