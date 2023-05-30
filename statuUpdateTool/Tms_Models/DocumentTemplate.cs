using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class DocumentTemplate
    {
        public long DocumentTemplateId { get; set; }
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public long TypeLookupId { get; set; }
        public string? DataSource { get; set; }
        public string? Template { get; set; }
        public string? DefaultPrinterName { get; set; }
        public long? AccountId { get; set; }
        public long? CarrierId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual TypeLookup TypeLookup { get; set; } = null!;
    }
}
