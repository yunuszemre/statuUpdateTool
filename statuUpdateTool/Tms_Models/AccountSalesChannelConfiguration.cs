using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class AccountSalesChannelConfiguration
    {
        public long AccountSalesChannelConfigurationId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long SalesChannelId { get; set; }
        public string? MerchantId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? ServiceUrl { get; set; }
        public bool? NotTrackedBySalesChannel { get; set; }
        public bool? CommonLabelIntegrationExists { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual SalesChannel SalesChannel { get; set; } = null!;
    }
}
