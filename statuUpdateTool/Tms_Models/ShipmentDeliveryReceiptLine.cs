using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ShipmentDeliveryReceiptLine
    {
        public long ShipmentDeliveryReceiptLineId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long ShipmentDeliveryReceiptId { get; set; }
        public long ShipmentId { get; set; }
        public string BarcodeValue { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[]? RowVersion { get; set; }
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual Shipment Shipment { get; set; } = null!;
        public virtual ShipmentDeliveryReceipt ShipmentDeliveryReceipt { get; set; } = null!;
    }
}
