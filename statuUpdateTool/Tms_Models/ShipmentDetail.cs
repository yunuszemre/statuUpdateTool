using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ShipmentDetail
    {
        public long ShipmentDetailId { get; set; }
        public long? ShipmentId { get; set; }
        public string? CustomerSpecificCode { get; set; }
        public string? LabelSequenceNumber { get; set; }
        public bool? IsLastSequence { get; set; }
        public bool? IsFragile { get; set; }
        public bool? IsActive { get; set; }
        public string? CustomerShipmentNumber { get; set; }
        public bool? IsShippedByCustomer { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public decimal? VolumetricWeight { get; set; }
        public decimal? WeightKg { get; set; }

        public virtual Shipment? Shipment { get; set; }
    }
}
