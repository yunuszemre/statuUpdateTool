using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class StatusLookup
    {
        public StatusLookup()
        {
            Consignments = new HashSet<Consignment>();
            IntegrationHistories = new HashSet<IntegrationHistory>();
            ReportHistories = new HashSet<ReportHistory>();
            ShipmentDeliveryReceipts = new HashSet<ShipmentDeliveryReceipt>();
            ShipmentShipmentStatuses = new HashSet<Shipment>();
            ShipmentStatusMappings = new HashSet<ShipmentStatusMapping>();
            ShipmentSystemStatuses = new HashSet<Shipment>();
        }

        public long StatusLookupId { get; set; }
        public string Code { get; set; } = null!;
        public long ProcessGroupId { get; set; }
        public string Description { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual ProcessGroup ProcessGroup { get; set; } = null!;
        public virtual ICollection<Consignment> Consignments { get; set; }
        public virtual ICollection<IntegrationHistory> IntegrationHistories { get; set; }
        public virtual ICollection<ReportHistory> ReportHistories { get; set; }
        public virtual ICollection<ShipmentDeliveryReceipt> ShipmentDeliveryReceipts { get; set; }
        public virtual ICollection<Shipment> ShipmentShipmentStatuses { get; set; }
        public virtual ICollection<ShipmentStatusMapping> ShipmentStatusMappings { get; set; }
        public virtual ICollection<Shipment> ShipmentSystemStatuses { get; set; }
    }
}
