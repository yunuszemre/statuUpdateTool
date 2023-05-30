using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class CarrierDistanceLookup
    {
        public CarrierDistanceLookup()
        {
            AccountCarrierDistanceDesiCosts = new HashSet<AccountCarrierDistanceDesiCost>();
            CarrierDistanceBetweenCityGroups = new HashSet<CarrierDistanceBetweenCityGroup>();
        }

        public long CarrierDistanceLookupId { get; set; }
        public long CarrierId { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Carrier Carrier { get; set; } = null!;
        public virtual ICollection<AccountCarrierDistanceDesiCost> AccountCarrierDistanceDesiCosts { get; set; }
        public virtual ICollection<CarrierDistanceBetweenCityGroup> CarrierDistanceBetweenCityGroups { get; set; }
    }
}
