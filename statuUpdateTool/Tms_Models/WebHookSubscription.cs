using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class WebHookSubscription
    {
        public long WebHookSubscriptionId { get; set; }
        public long WebHookTypeId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public string WebHookUrl { get; set; } = null!;
        public string? AuthUrl { get; set; }
        public string? ApiKey { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool IsBasicAuth { get; set; }
        public bool IsAuthenticationRequired { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
    }
}
