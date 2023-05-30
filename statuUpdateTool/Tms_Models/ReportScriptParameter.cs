using System;
using System.Collections.Generic;

namespace statuUpdateTool.Tms_Models
{
    public partial class ReportScriptParameter
    {
        public long ReportScriptParameterId { get; set; }
        public long ReportScriptId { get; set; }
        public string ParameterText { get; set; } = null!;
        public long ParameterNameTypeId { get; set; }
        public long ParameterDataTypeId { get; set; }
        public bool? IsSortable { get; set; }
        public bool? IsNullable { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreateUserIdentityId { get; set; }
        public DateTime? ChangedDate { get; set; }
        public long? ChangeUserIdentityId { get; set; }
        public long RecordStatusId { get; set; }
        public byte[] RowVersion { get; set; } = null!;
        public bool IfTransferredToSecondary { get; set; }

        public virtual TypeLookup ParameterDataType { get; set; } = null!;
        public virtual TypeLookup ParameterNameType { get; set; } = null!;
        public virtual ReportScript ReportScript { get; set; } = null!;
    }
}
