using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class SalesChannel
    {
        public SalesChannel()
        {
            AccountSalesChannelConfigurations = new HashSet<AccountSalesChannelConfiguration>();
            Consignments = new HashSet<Consignment>();
        }

        public long SalesChannelId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual ICollection<AccountSalesChannelConfiguration> AccountSalesChannelConfigurations { get; set; }
        public virtual ICollection<Consignment> Consignments { get; set; }
    }
}
