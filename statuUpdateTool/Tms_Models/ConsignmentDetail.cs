using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ConsignmentDetail
    {
        public long ConsignmentDetailId { get; set; }
        public long ConsignmentId { get; set; }
        public string? ProductCode { get; set; }
        public string? Barcode { get; set; }
        public string? ProductName { get; set; }
        public string? LineId { get; set; }
        public int? LineQuantity { get; set; }
        public decimal? ProductPrice { get; set; }
        public string? ProductTypeCode { get; set; }
        public decimal? ProductVolumetricWeight { get; set; }
        public decimal? ProductWeight { get; set; }
        public long? LocationId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
        public string? Productattr1 { get; set; }
        public string? Productattr2 { get; set; }
        public string? Productattr3 { get; set; }
        public string? Productattr4 { get; set; }
        public string? Productattr5 { get; set; }

        public virtual Consignment Consignment { get; set; } = null!;
        public virtual Location? Location { get; set; }
    }
}
