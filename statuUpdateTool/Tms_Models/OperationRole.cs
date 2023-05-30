using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class OperationRole
    {
        public OperationRole()
        {
            OperationRoleOperationClaims = new HashSet<OperationRoleOperationClaim>();
            UserIdentityOperationRoles = new HashSet<UserIdentityOperationRole>();
        }

        public long OperationRoleId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual ICollection<OperationRoleOperationClaim> OperationRoleOperationClaims { get; set; }
        public virtual ICollection<UserIdentityOperationRole> UserIdentityOperationRoles { get; set; }
    }
}
