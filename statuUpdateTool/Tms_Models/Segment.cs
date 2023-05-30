using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class Segment
    {
        public Segment()
        {
            CustomerSegments = new HashSet<CustomerSegment>();
        }

        public long SegmentId { get; set; }
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public long CarrierId { get; set; }
        public int Priority { get; set; }
        public long? CountryId { get; set; }
        public long? CityId { get; set; }
        public long? TownId { get; set; }
        public long? DistrictId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual Carrier Carrier { get; set; } = null!;
        public virtual City? City { get; set; }
        public virtual Country? Country { get; set; }
        public virtual District? District { get; set; }
        public virtual Town? Town { get; set; }
        public virtual ICollection<CustomerSegment> CustomerSegments { get; set; }
    }
}
