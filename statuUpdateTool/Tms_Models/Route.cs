using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class Route
    {
        public Route()
        {
            CarDrivers = new HashSet<CarDriver>();
            Consignments = new HashSet<Consignment>();
            RouteLocations = new HashSet<RouteLocation>();
            ShipmentDeliveryReceipts = new HashSet<ShipmentDeliveryReceipt>();
        }

        public long RouteId { get; set; }
        public long ClientId { get; set; }
        public long AccountId { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public DateTime? ChangedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public string RouteName { get; set; } = null!;
        public int? Count { get; set; }

        public virtual Account Account { get; set; } = null!;
        public virtual Client Client { get; set; } = null!;
        public virtual ICollection<CarDriver> CarDrivers { get; set; }
        public virtual ICollection<Consignment> Consignments { get; set; }
        public virtual ICollection<RouteLocation> RouteLocations { get; set; }
        public virtual ICollection<ShipmentDeliveryReceipt> ShipmentDeliveryReceipts { get; set; }
    }
}
