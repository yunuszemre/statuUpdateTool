using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class OperationRoleOperationClaim
    {
        public long OperationRoleOperationClaimId { get; set; }
        public long OperationRoleId { get; set; }
        public long OperationClaimId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual OperationClaim OperationClaim { get; set; } = null!;
        public virtual OperationRole OperationRole { get; set; } = null!;
    }
}
