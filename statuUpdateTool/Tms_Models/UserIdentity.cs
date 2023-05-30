using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class UserIdentity
    {
        public UserIdentity()
        {
            AccountChangeUserIdentities = new HashSet<Account>();
            AccountCreateUserIdentities = new HashSet<Account>();
            AccountLocationWorkingScheduleChangeUserIdentities = new HashSet<AccountLocationWorkingSchedule>();
            AccountLocationWorkingScheduleCreateUserIdentities = new HashSet<AccountLocationWorkingSchedule>();
            InverseChangeUserIdentity = new HashSet<UserIdentity>();
            InverseCreateUserIdentity = new HashSet<UserIdentity>();
            ReportHistoryChangeUserIdentities = new HashSet<ReportHistory>();
            ReportHistoryCreateUserIdentities = new HashSet<ReportHistory>();
            UserIdentityAccountChangeUserIdentities = new HashSet<UserIdentityAccount>();
            UserIdentityAccountCreateUserIdentities = new HashSet<UserIdentityAccount>();
            UserIdentityAccountUserIdentities = new HashSet<UserIdentityAccount>();
            UserIdentityClientChangeUserIdentities = new HashSet<UserIdentityClient>();
            UserIdentityClientCreateUserIdentities = new HashSet<UserIdentityClient>();
            UserIdentityClientUserIdentities = new HashSet<UserIdentityClient>();
            UserIdentityLocationChangeUserIdentities = new HashSet<UserIdentityLocation>();
            UserIdentityLocationCreateUserIdentities = new HashSet<UserIdentityLocation>();
            UserIdentityLocationUserIdentities = new HashSet<UserIdentityLocation>();
            UserIdentityOperationClaimChangeUserIdentities = new HashSet<UserIdentityOperationClaim>();
            UserIdentityOperationClaimCreateUserIdentities = new HashSet<UserIdentityOperationClaim>();
            UserIdentityOperationClaimUserIdentities = new HashSet<UserIdentityOperationClaim>();
            UserIdentityOperationRoleChangeUserIdentities = new HashSet<UserIdentityOperationRole>();
            UserIdentityOperationRoleCreateUserIdentities = new HashSet<UserIdentityOperationRole>();
            UserIdentityOperationRoleUserIdentities = new HashSet<UserIdentityOperationRole>();
        }

        public long UserIdentityId { get; set; }
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? IdentityNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public byte[]? PasswordHash { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenEndDate { get; set; }
        public long? LastLoggedInClientId { get; set; }
        public long? LastLoggedInAccountId { get; set; }
        public long? LastLoggedInLocationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual UserIdentity? ChangeUserIdentity { get; set; }
        public virtual UserIdentity CreateUserIdentity { get; set; } = null!;
        public virtual ICollection<Account> AccountChangeUserIdentities { get; set; }
        public virtual ICollection<Account> AccountCreateUserIdentities { get; set; }
        public virtual ICollection<AccountLocationWorkingSchedule> AccountLocationWorkingScheduleChangeUserIdentities { get; set; }
        public virtual ICollection<AccountLocationWorkingSchedule> AccountLocationWorkingScheduleCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentity> InverseChangeUserIdentity { get; set; }
        public virtual ICollection<UserIdentity> InverseCreateUserIdentity { get; set; }
        public virtual ICollection<ReportHistory> ReportHistoryChangeUserIdentities { get; set; }
        public virtual ICollection<ReportHistory> ReportHistoryCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityAccount> UserIdentityAccountChangeUserIdentities { get; set; }
        public virtual ICollection<UserIdentityAccount> UserIdentityAccountCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityAccount> UserIdentityAccountUserIdentities { get; set; }
        public virtual ICollection<UserIdentityClient> UserIdentityClientChangeUserIdentities { get; set; }
        public virtual ICollection<UserIdentityClient> UserIdentityClientCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityClient> UserIdentityClientUserIdentities { get; set; }
        public virtual ICollection<UserIdentityLocation> UserIdentityLocationChangeUserIdentities { get; set; }
        public virtual ICollection<UserIdentityLocation> UserIdentityLocationCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityLocation> UserIdentityLocationUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationClaim> UserIdentityOperationClaimChangeUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationClaim> UserIdentityOperationClaimCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationClaim> UserIdentityOperationClaimUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationRole> UserIdentityOperationRoleChangeUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationRole> UserIdentityOperationRoleCreateUserIdentities { get; set; }
        public virtual ICollection<UserIdentityOperationRole> UserIdentityOperationRoleUserIdentities { get; set; }
    }
}
