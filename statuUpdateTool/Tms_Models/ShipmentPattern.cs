using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ShipmentPattern
    {
        public long ShipmentPatternId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long CarrierId { get; set; }
        public string? PatternContent { get; set; }
        public decimal? Desi { get; set; }
        public int? ParcelCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[]? RowVersion { get; set; }
        public bool IfTransferredToSecondary { get; set; }
        public int Counter { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Carrier Carrier { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
    }
}
