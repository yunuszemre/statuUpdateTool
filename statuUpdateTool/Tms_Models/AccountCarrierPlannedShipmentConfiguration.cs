using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class AccountCarrierPlannedShipmentConfiguration
    {
        public long AccountCarrierPlannedShipmentConfigurationId { get; set; }
        public long LocationCarrierConfigurationId { get; set; }
        public long DeliveryTypeId { get; set; }
        public long DeliverySlotTypeId { get; set; }
        public int? MinOpertaionTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual TypeLookup DeliverySlotType { get; set; } = null!;
        public virtual TypeLookup DeliveryType { get; set; } = null!;
        public virtual LocationCarrierConfiguration LocationCarrierConfiguration { get; set; } = null!;
    }
}
