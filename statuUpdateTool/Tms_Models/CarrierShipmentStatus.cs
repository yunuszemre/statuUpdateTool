using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class CarrierShipmentStatus
    {
        public long CarrierShipmentStatusId { get; set; }
        public long CarrierId { get; set; }
        public string? StatusCode { get; set; }
        public string? StatusDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Carrier Carrier { get; set; } = null!;
    }
}
