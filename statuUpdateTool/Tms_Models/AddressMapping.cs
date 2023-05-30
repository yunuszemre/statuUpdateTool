using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class AddressMapping
    {
        public long AddressMappingId { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
    }
}
