using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ShipmentCarrierHistory
    {
        public long ShipmentCarrierHistoryId { get; set; }
        public long? ShipmentId { get; set; }
        public string? CarrierStatus { get; set; }
        public string? ArrivalCenter { get; set; }
        public string? FromLocation { get; set; }
        public string? ToLocation { get; set; }
        public string? BranchOffice { get; set; }
        public string? ShipmentRemarks { get; set; }
        public string? CarrierEmployeeName { get; set; }
        public string? RecipientName { get; set; }
        public DateTime? ReceivedTime { get; set; }
        public DateTime? CarrierEventTime { get; set; }
        public string? CityName { get; set; }
        public string? TownName { get; set; }
        public string? ReasonId { get; set; }
        public string? ReasonDescription { get; set; }
        public string? CarrierKey { get; set; }
        public string? CarrierTrackingNumber { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Shipment? Shipment { get; set; }
    }
}
