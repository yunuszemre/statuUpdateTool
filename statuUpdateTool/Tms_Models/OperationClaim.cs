using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class OperationClaim
    {
        public OperationClaim()
        {
            OperationRoleOperationClaims = new HashSet<OperationRoleOperationClaim>();
            UserIdentityOperationClaims = new HashSet<UserIdentityOperationClaim>();
        }

        public long OperationClaimId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long? MenuId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual ICollection<OperationRoleOperationClaim> OperationRoleOperationClaims { get; set; }
        public virtual ICollection<UserIdentityOperationClaim> UserIdentityOperationClaims { get; set; }
    }
}
