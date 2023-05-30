using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ShipmentStatusMapping
    {
        public long ShipmentStatusMappingId { get; set; }
        public long CarrierId { get; set; }
        public long CarrierShipmentStatusId { get; set; }
        public long ShipmentStatusId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Carrier Carrier { get; set; } = null!;
        public virtual StatusLookup ShipmentStatus { get; set; } = null!;
    }
}
