using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class Car
    {
        public Car()
        {
            CarDrivers = new HashSet<CarDriver>();
            ShipmentDeliveryReceipts = new HashSet<ShipmentDeliveryReceipt>();
        }

        public long CarId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long CarTypeId { get; set; }
        public string CarPlate { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual TypeLookup CarType { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<CarDriver> CarDrivers { get; set; }
        public virtual ICollection<ShipmentDeliveryReceipt> ShipmentDeliveryReceipts { get; set; }
    }
}
