using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ValueMapping
    {
        public long ValueMappingId { get; set; }
        public long ValueMappingTypeId { get; set; }
        public long ValueKeyId { get; set; }
        public string ValueKeyText { get; set; } = null!;
        public string ValueMatchingText { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }
    }
}
