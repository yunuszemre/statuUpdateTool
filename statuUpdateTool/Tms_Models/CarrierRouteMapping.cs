using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace statuUpdateTool.Tms_Models
{
    public class CarrierRouteMapping
    {
        public CarrierRouteMapping()
        {
            CarrierRouteMappingMobileBranches = new HashSet<CarrierRouteMappingMobileBranch>();
        }
   
        public long CarrierRouteMappingId { get; set; }
        public long CarrierId { get; set; }
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? TownId { get; set; }
        public long? DistrictId { get; set; }
        public int? RoutingLevel { get; set; }
        public bool? IsMobileBranch { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Carrier Carrier { get; set; }
        public virtual City? City { get; set; }
        public virtual Country? Country { get; set; }
        public virtual District? District { get; set; }
        public virtual Town? Town { get; set; }
        public virtual ICollection<CarrierRouteMappingMobileBranch> CarrierRouteMappingMobileBranches { get; set; }
    }
}
