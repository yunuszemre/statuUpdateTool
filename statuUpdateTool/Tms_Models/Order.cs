using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class Order
    {
        public Order()
        {
            Consignments = new HashSet<Consignment>();
        }

        public long OrderId { get; set; }
        public string OrderNumber { get; set; } = null!;
        public long? ClientId { get; set; }
        public long? AccountId { get; set; }
        public long? TotalQuantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? VersionNumber { get; set; }
        public bool? SendSmsNotification { get; set; }
        public bool? SendEmailNotification { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account? Account { get; set; }
        public virtual Client? Client { get; set; }
        public virtual ICollection<Consignment> Consignments { get; set; }
    }
}
